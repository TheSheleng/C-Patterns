using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal interface ICommand
    {
        void Execute();
        void UnExecute();
    }
    internal class CalculatorCommand : ICommand
    { 
        char _operator;
        int operand;
        Calculator calculator;
        public CalculatorCommand(Calculator calculator, char _operator, int operand)
        { 
            this.calculator = calculator;
            this._operator = _operator;
            this.operand = operand;
        }
        public void Execute() => calculator.Operation(_operator, operand);
        public void UnExecute() => calculator.Operation(Undo(_operator), operand);
        char Undo(char _operator)
        {
            switch (_operator)
            { 
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: return _operator;
            }
        }
    }
}
