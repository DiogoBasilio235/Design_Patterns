using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class FileWriter
    {
        public string fileName = DateTime.Now.ToFileTime().ToString();

        public void WriteToFile(string line) => 
            File.AppendAllText(fileName, line + Environment.NewLine);
    }
}
