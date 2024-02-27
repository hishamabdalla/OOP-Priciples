using Abstruction;

namespace Abstraction

{
    public class SavingAccount:BankAccount
    {
        private const decimal DailyWithdrawaLimit = 2000;

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
