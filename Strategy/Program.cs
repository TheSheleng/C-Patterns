using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlaceOnMap airport = new PlaceOnMap("ODS", 154);
            Transport transport;

            transport = new Bike(airport);
            Console.WriteLine($"Transport Bike:\nTime: {transport.GetTime()};\nPrice: {transport.GetFullPrice()};\n");

            transport = new Bus(airport);
            Console.WriteLine($"Transport Bus:\nTime: {transport.GetTime()};\nPrice: {transport.GetFullPrice()};\n");

            transport = new Taxi(airport);
            Console.WriteLine($"Transport Taxi:\nTime: {transport.GetTime()};\nPrice: {transport.GetFullPrice()};\n");

            Console.ReadKey();
        }
    }
}
