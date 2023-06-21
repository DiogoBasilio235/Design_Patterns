using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class UpCommand : ICommand
    {
        public void Invoke()
        {
            Console.Write("Up ");
            Program.y++;
        }

        public void Undo()
        {
            Console.Write("Down ");
            Program.y--;
        }

    }
}
