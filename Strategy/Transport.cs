using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class Transport
    {
        protected PlaceOnMap destination;
        public Transport(PlaceOnMap destination) => this.destination = destination;
        public abstract float GetFullPrice();
        public abstract float GetTime();
    }
    internal class Bike : Transport
    {
        public Bike(PlaceOnMap destination) : base(destination) { }
        public override float GetFullPrice() => 0;
        public override float GetTime() => base.destination.Distance * 3;
    }
    internal class Bus : Transport
    {
        public Bus(PlaceOnMap destination) : base(destination) { }
        public override float GetFullPrice() => 15;
        public override float GetTime() => base.destination.Distance * 2;
    }
    internal class Taxi : Transport
    {
        public Taxi(PlaceOnMap destination) : base(destination) { }
        public override float GetFullPrice() 
        {
            float p = base.destination.Distance * 6;
            if (p < 50) return 50;
            else return p;
        }
        public override float GetTime() => base.destination.Distance * 1;
    }
}
