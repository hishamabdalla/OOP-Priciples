namespace Encapsulation
{
    class BankAccount
    {
        private readonly string _accNo;
        private decimal _balance;

        public BankAccount(string accNo,decimal InitialBalance)
        {
            _accNo = accNo;
            _balance = InitialBalance;
            Log("Bank Account is Created");
        }

        public decimal Balance=>_balance;
        public string AccNo => _accNo;
        
        //public string AccountNo { 
        //    get
        //    {
        //        return _accNo;
        //    }
        //    set 
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //           { Log("INVALID ACCOUNT NO"); }
        //           _accNo = value;
        //    }
        //}
        //public void SetAccNo(string accNo)
        //{
        //    if(string.IsNullOrWhiteSpace(accNo)) 
        //    { Log("INVALID ACCOUNT NO"); }
        //    _accNo = accNo;
        //}
        
        public string GetAccNo()
        {
            return _accNo;
        }

        public void SetBalance(decimal balance)
        {
            if (balance < 0)
            { Log("INVALID Balance"); }
            _balance = balance;
        }
        public decimal GetBalance ()
        {
            return _balance;
        }
        public void Deposit(decimal amount)
        {
            if(amount <= 0) 
            {
                Log("REJECTED: Deposit NEGATIVE !!!!");
                return;
            }
            _balance += amount;
            Log($"ACCEPTED: {amount.ToString("C")} deposited");
        }
        public void Withdraw(decimal amount)
        {
            const decimal MaxWithdraw = 1000;
            if(amount > MaxWithdraw) 
            {
                Log("REJECTED: Max Withdraw !!!!");
                return;
            }

            if (amount > _balance)
            {
                Log("REJECTED: INSUFFICIENT BALANCE !!!!");
                return;
            }
            _balance -= amount; 
           
            Log($"ACCEPTED : {amount.ToString("C")} Withdrawed");

        }
        private void Log(string message)
        {
            var time=DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            Console.WriteLine($"[{time}] {message}");
            Console.WriteLine($"[{time}] Balance info: Account No: '{_accNo}' , Balance:'{_balance.ToString("C")}' ");
        }

    }
}
