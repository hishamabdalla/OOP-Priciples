using Abstruction;

namespace Abstruction

{
    public class CheckingAccount :BankAccount
    {
        private const decimal DailyWithdrawaLimit = 5000;
        public override void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException();
            }
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException();
            }
            if (amount > DailyWithdrawaLimit)
            {
                throw new InvalidOperationException();
            }

            Balance -= amount;

        }
    }
}
