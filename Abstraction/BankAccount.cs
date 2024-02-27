using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction

{
    public abstract class BankAccount
    {
        public string AccountNumber {  get; set; }
        public decimal Balance { get; set; }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

    }
}
