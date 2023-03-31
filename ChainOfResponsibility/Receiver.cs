using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Receiver
    {
        bool BankTransfer;
        bool MoneyTransfer;
        bool PayPalTransfer;
        public Receiver(bool bt, bool mt, bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
        public bool GetBankTransfer() => BankTransfer;
        public bool GetMoneyTransfer() => MoneyTransfer;
        public bool GetPayPalTransfer() => PayPalTransfer;
        public void SetBankTransfer(bool BankTransfer) => this.BankTransfer = BankTransfer;
        public void SetMoneyTransfer(bool MoneyTransfer) => this.MoneyTransfer = MoneyTransfer;
        public void SetPayPalTransfer(bool PayPalTransfer) => this.PayPalTransfer = PayPalTransfer;
    }
}
