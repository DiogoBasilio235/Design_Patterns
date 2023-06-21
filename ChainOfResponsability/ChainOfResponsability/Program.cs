using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an int to divide Max Int By:");
            try 
            {
                LineReader.ReadLines();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Quit trying to divide by zero, you might break something.");
            }
        }
    }
}