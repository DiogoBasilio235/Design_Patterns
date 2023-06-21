using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public static class OneFileAtATime
    {
        static readonly object FileInUse = new Object();

        public static void AppendAllText(string filename, string text) 
        {
            lock(FileInUse) 
            {
                File.AppendAllText(filename, text);
            }
            
        }
    }
}