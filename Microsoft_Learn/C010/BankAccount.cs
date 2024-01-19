using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C010
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int s_accountNumberSeed = 1000100000;

        private List<Transaction> _allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Number = s_accountNumberSeed.ToString(); //não precisa do this
            s_accountNumberSeed++;

            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive"); //THROW => foi criada uma exceção
            }
            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            // HEADER
            report.AppendLine("Date\t\tAmout\tNote");
            foreach (var item in _allTransactions)
            {
                // ROWS
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount:C}\t{item.Notes}");
            }
            return report.ToString();
        }

    }
}
