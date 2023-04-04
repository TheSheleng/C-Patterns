using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPlace> places = new List<IPlace>() {
                new PrivateHouse(),
                new Factory(),
                new Bank(),
                new Shop(),
                new CarPark(),
                new Hospital()
            };

            Insurer insurer = new Insurer();
            foreach (var place in places)
            {
                place.Accept(insurer);
            }

            Console.ReadKey();
        }
    }
}
