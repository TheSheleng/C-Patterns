using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IVisitor
    {
        void Visit(PrivateHouse privatehouse);
        void Visit(Factory factory);
        void Visit(Bank bank);
        void Visit(Shop shop);
        void Visit(CarPark carPark);
        void Visit(Hospital hospital);
    }
    internal class Insurer : IVisitor
    {
        public void Visit(PrivateHouse privatehouse) => Console.WriteLine("The private house signed up for property insurance.");
        public void Visit(Factory factory) => Console.WriteLine("The factory signed up for fire insurance.");
        public void Visit(Bank bank) => Console.WriteLine("The bank signed up for money theft insurance.");
        public void Visit(Shop shop) => Console.WriteLine("The store signed up for food theft insurance.");
        public void Visit(CarPark carPark) => Console.WriteLine("The fleet signed up for car theft insurance.");
        public void Visit(Hospital hospital) => Console.WriteLine("The hospital signed up for medical theft insurance.");
    }
}
