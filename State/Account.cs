using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Account
    {
        State state;
        string owner;
        public Account(string owner) => this.owner = owner;
        public double GetBalance() => state.GetBalance();
        public State GetState() => state;
        public void SetState(State state) => this.state = state;
        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine($"Deposited {amount}$ -----");
            Console.WriteLine($"Balance {this.GetBalance()}$");
            Console.WriteLine($"Status {state.GetType().Name}\n");
        }
        public void Withdraw(double amount)
        {
            if (!state.Withdraw(amount)) return;
            Console.WriteLine($"Withdraw {amount}$ -----");
            Console.WriteLine($"Balance {this.GetBalance()}$");
            Console.WriteLine($"Status {state.GetType().Name}\n");
        }
        public void PayInterest() 
        {
            if (!state.PayInterest()) return;
            Console.WriteLine($"Interest Paid -----");
            Console.WriteLine($"Balance {this.GetBalance()}$");
            Console.WriteLine($"Status {state.GetType().Name}\n");
        }
    }
}
