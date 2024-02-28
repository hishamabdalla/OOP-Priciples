namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("A_41233",6000);

            //account.SetAccNo("A_41233");
            //account.AccountNo = "W_23232";
            account.Deposit(900);
            account.Withdraw(200);
        }
    }
}
