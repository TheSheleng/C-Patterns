using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IPlace
    {
        void Accept(IVisitor visitor);
    }
    internal class PrivateHouse : IPlace
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
    internal class Factory : IPlace
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
    internal class Bank : IPlace
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
    internal class Shop : IPlace
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
    internal class CarPark : IPlace
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
    internal class Hospital : IPlace
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
