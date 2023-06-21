using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORGrocery
{
    public class ConsoleItemHandler : IItemHandler
    {
        public IItemHandler Next { get; set; }

        public void Handle(string line)
        {
            Console.WriteLine(line);
            Next?.Handle(line);
        }
    }
}
