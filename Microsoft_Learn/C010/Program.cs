//Object Oriented Programming: Objects and Classes

namespace C010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Analu", 35000);
            Console.WriteLine($"Account number {account.Number} was created for {account.Owner} with {account.Balance}");

            var account2 = new BankAccount("Lala", 14700);
            Console.WriteLine($"Account number {account2.Number} was created for {account2.Owner} with {account2.Balance}");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            account.MakeWithdrawal(3200, DateTime.Now, "Buy Iphone");
            account.MakeWithdrawal(5200, DateTime.Now, "Buy Ipad");

            account2.MakeDeposit(2000, DateTime.Now, "Friend paid me back");
            account2.MakeDeposit(5000, DateTime.Now, "Wage");


            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine($"TOTAL: ACCOUNT number: {account.Number} => {account.Balance:C}");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");


            Console.WriteLine(account2.GetAccountHistory());
            Console.WriteLine($"TOTAL: ACCOUNT number: {account2.Number} => {account2.Balance:C}");


            //// Test that the initial balances must be positive.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}
            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(88750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
