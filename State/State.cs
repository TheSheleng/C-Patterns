using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal abstract class State
    {
        protected Account account;
        protected double balance;
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;
        public Account GetAccount() => account;
        public double GetBalance() => balance;
        public void SetBalance(double balance) => this.balance = balance;
        public abstract void Deposit(double amount); 
        public abstract bool Withdraw(double amount);
        public abstract bool PayInterest();
    }
}
