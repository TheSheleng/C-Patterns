using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal abstract class Aircraft
    {
        protected Dispatcher Dispatcher;
        public Aircraft(Dispatcher dispatcher) => Dispatcher = dispatcher;
        public void SetDispatcher(Dispatcher dispatcher) => Dispatcher = dispatcher;
        public abstract void MakeLanding();
        public abstract void TakeWing();
        public abstract void Notify(Dispatcher sender, string msg);
    }

    internal class Airplane : Aircraft
    {
        public Airplane(Dispatcher dispatcher) : base(dispatcher) { }
        public override void MakeLanding()
        {
            Dispatcher.Notify(this, "Запрашиваю разрешение на посадку");
        }
        public override void TakeWing()
        {
            Dispatcher.Notify(this, "Запрашиваю разрешение на взлёт");
        }
        public override void Notify(Dispatcher sender, string msg)
        {
            if (msg == "Разрешаю посадку.") sender.Notify(this, "Начанаю посадку.");
            else if (msg == "Разрешаю взлёт.") sender.Notify(this, "Начинаю взлёт.");
        }
    }

    internal class Helicopter : Aircraft
    {
        public Helicopter(Dispatcher dispatcher) : base(dispatcher) { }
        public override void MakeLanding()
        {
            Dispatcher.Notify(this, "Запрашиваю разрешение на посадку");
        }
        public override void TakeWing()
        {
            Dispatcher.Notify(this, "Запрашиваю разрешение на взлёт");
        }
        public override void Notify(Dispatcher sender, string msg)
        {
            if (msg == "Разрешаю посадку.") sender.Notify(this, "Начанаю посадку.");
            else if (msg == "Разрешаю взлёт.") sender.Notify(this, "Начинаю взлёт.");
        }
    }
}
