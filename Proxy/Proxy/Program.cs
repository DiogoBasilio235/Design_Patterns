using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i => OneFileAtATime.AppendAllText("A.txt", i + ", "));
        }
    }
}