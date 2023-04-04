using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Memento
{
    internal class Memento
    {
        public string State { get; }
        public Memento(string state) => State = state;
    }
    internal class Originator
    {
        public string State { get; private set; } = "";
        public Memento Save() => new Memento(State);
        public void Restore(Memento m)
        { 
            State = m.State; 
        }
        public void Add(string str) => State += str;
        public void Dell(int start, int count) => State.Remove(start, count);
    }
}
