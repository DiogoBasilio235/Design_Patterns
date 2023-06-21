using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DownCommand : ICommand
    {
        public void Invoke()
        {
            Console.Write("Down ");
            Program.y--;
        }
        public void Undo()
        {
            Console.Write("Up ");
            Program.y++;
        }
    }
}
