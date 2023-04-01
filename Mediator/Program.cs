using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();

            Airplane airplane1 = new Airplane(dispatcher);
            Airplane airplane2 = new Airplane(dispatcher);
            Helicopter helicopter = new Helicopter(dispatcher);

            airplane1.MakeLanding();
            dispatcher.PrintGarage();

            helicopter.MakeLanding();
            dispatcher.PrintGarage();

            airplane1.TakeWing();
            dispatcher.PrintGarage();

            airplane2.MakeLanding();
            dispatcher.PrintGarage();

            airplane2.TakeWing();
            dispatcher.PrintGarage();

            helicopter.TakeWing();
            dispatcher.PrintGarage();

            Console.ReadKey();
        }
    }
}
