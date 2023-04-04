using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            LinkedList<Memento> history = new LinkedList<Memento>();
            history.AddFirst(originator.Save());

            while (true)
            {
                Console.CursorTop = 1; 
                Console.Write(new string(' ', Console.BufferWidth));
                Console.CursorTop--;
                Console.WriteLine(originator.Save().State);
                switch (EnterAction())
                {
                    case 0: //Add
                        {
                            originator.Add(EnterString());
                            if (history.Count > 256) history.RemoveLast();
                            history.AddFirst(originator.Save());
                            break;
                        }
                    case 1: //Dell
                        {
                            originator.Dell(EnterIndex(), EnterIndex());
                            if (history.Count > 256) history.RemoveLast();
                            history.AddFirst(originator.Save());
                            break;
                        }
                    case 2: //Undo
                        {
                            if (history.Count > 1)
                            {
                                 history.RemoveFirst();
                                 originator.Restore(history.First());
                            }
                            break;
                        }
                }
            }
        }
        static int EnterAction()
        {
            string[] PunctName =  new string[]
                { 
                    "Add",
                    "Dell",
                    "Undo",
                };

            int action = 0;
            while (true)
            {
                for (int i = 0; i < PunctName.Length; i++)
                {
                    if (i == action) Console.Write("> ");
                    Console.Write($"{PunctName[i]}  ");
                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow: action = (action == 0 ? PunctName.Length - 1 : action - 1); break;
                    case ConsoleKey.RightArrow: action = (action == PunctName.Length - 1 ? 0 : action + 1); break;
                    case ConsoleKey.Enter: return action;
                }
                Console.CursorLeft = 0;
            }
        }
        static string EnterString()
        {
            Console.CursorTop++;
            while (true)
            {
                Console.Write("Enter string: ");
                string res = Console.ReadLine();
                Console.CursorTop--;
                Console.Write(new string(' ', Console.BufferWidth));
                Console.CursorTop--;
                if (res != "") return res;
                Console.CursorLeft = 0;
            }
        }
        static int EnterIndex()
        {
            Console.CursorTop++;
            while (true)
            {
                Console.Write("Enter index: ");
                int res = Convert.ToInt16(Console.ReadLine());
                Console.CursorTop--;
                Console.Write(new string(' ', Console.BufferWidth));
                Console.CursorTop--;
                if (res > -1) return res;
                Console.CursorLeft = 0;
            }
        }
    }
}
