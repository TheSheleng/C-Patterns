using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Invoker(User user, ICommand command) => user.Compute(command);
        static void Main(string[] args)
        {
            User user = new User();
            Calculator calculator = new Calculator(); 

            ICommand command = new CalculatorCommand(calculator, '+', 100); 
            Invoker(user, command);

            command = new CalculatorCommand(calculator, '-', 50);
            Invoker(user, command);

            command = new CalculatorCommand(calculator, '*', 10);
            Invoker(user, command);

            command = new CalculatorCommand(calculator, '/', 2);
            Invoker(user, command);

            user.Undo(4);
            user.Redo(2);

            command = new CalculatorCommand(calculator, '*', 3);
            Invoker(user, command);

            Console.ReadKey();
        }
    }
}
