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

        }
    }
}
