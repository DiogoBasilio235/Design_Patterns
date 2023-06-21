using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORGrocery
{
    public class FileWritingItemHandler : IItemHandler
    {
        public string fileName = DateTime.Now.ToFileTime().ToString();
        public IItemHandler Next { get; set; }

        public void Handle(string line)
        {
            File.AppendAllText(fileName, line + Environment.NewLine);
            Next.Handle(line);
        }
    }
}
