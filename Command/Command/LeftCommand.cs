using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class LeftCommand : ICommand
    {
        public void Invoke()
        {
            Console.Write("Left ");
            Program.x--;
        }
        public void Undo()
        {
            Console.Write("right ");
            Program.x++;
        }
    }
}
