using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class RedState : State
    {
        void Initialize()
        {
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
        }
        void StateChangeCheck() 
        {
            if (balance > upperLimit) account.SetState(new SilverState(this));
        }
        public RedState(State state)
        {
            this.balance = state.GetBalance();
            this.account = state.GetAccount();
            Initialize();
        }
        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }
        public override bool Withdraw(double amount)
        {
            Console.WriteLine("No funds available for withdrawal!");
            return false;
        }
        public override bool PayInterest()
        {
            Console.WriteLine("No interest is paid!");
            return false;
        }
    }
}
