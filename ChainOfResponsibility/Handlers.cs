using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract internal class PaymentHandler
    {
        protected PaymentHandler Successor;
        public PaymentHandler GetHandler() => Successor;
        public void SetHandler(PaymentHandler Successor) => this.Successor = Successor;
        public abstract void Handle(Receiver receiver);
    }
    internal class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.GetBankTransfer()) Console.WriteLine("Bank transfer");
            else if (Successor != null) Successor.Handle(receiver);
        }
    };

    internal class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.GetMoneyTransfer()) Console.WriteLine("Transfer through money transfer systems");
            else if (Successor != null) Successor.Handle(receiver);
        }
    };

    internal class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.GetPayPalTransfer()) Console.WriteLine("Transfer via paypal");
            else if (Successor != null) Successor.Handle(receiver);
        }
    };
}
