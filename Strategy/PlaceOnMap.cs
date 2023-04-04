using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class PlaceOnMap
    {
        public string Name { get; }
        public float Distance { get; }
        public PlaceOnMap (string name, float distance)
        {
            Name = name;
            Distance = distance;
        }
    }
}
