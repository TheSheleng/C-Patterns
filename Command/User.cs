using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class User
    {
        List<ICommand> commands = new List<ICommand>();
        int current = 0;
        public void Redo(int levels)
        {
            Console.WriteLine($"\n---- Redo { levels} levels");
            for (int i = 0; i < levels; i++)
                if (current < commands.Count - 1)
                    commands[current++].Execute();
        }
        public void Undo(int levels)
        {
            Console.WriteLine($"\n---- Undo {levels} levels");
            for (int i = 0; i < levels; i++)
                if (current > 0)
                    commands[--current].UnExecute();
        }
        public void Compute(ICommand command)
        {
            command.Execute();
            this.commands.Add(command);
            current++;
        }
    }
}
