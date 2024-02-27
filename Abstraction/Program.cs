using Abstruction;

namespace Abstraction

{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new SavingAccount();
            account.AccountNumber = "1524684";
            account.Balance = 9000;
            account.Deposit(100);
            Console.WriteLine(account.Balance);
            account.Withdraw(2000);
            Console.WriteLine( account.Balance);

        }
    }
}
