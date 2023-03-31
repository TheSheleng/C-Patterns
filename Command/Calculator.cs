using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Calculator
    {
        int result = 0;
        public void Operation(char _operator, int operand)
        {
            switch (_operator)
            { 
                case '+': result += operand; break;
                case '-': result -= operand; break;
                case '*': result *= operand; break;
                case '/': result /= operand; break;
            }
            Console.WriteLine($"Current value = {result} (following {_operator}{operand})");
        }
    }
}
