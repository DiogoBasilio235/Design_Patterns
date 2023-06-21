using System;

namespace ChainOfResponsability
{
    public static class LineReader
    {
        public static void ReadLines() 
        {
            while(true) {
                try {
                    TheGreatDivider.MaxIntDivideBy(Console.ReadLine());
                } 
                catch (FormatException ex) 
                {
                    Console.WriteLine("Caught: " + ex.Message);
                } 
                catch (ArgumentException) 
                {
                    Console.WriteLine("Enter A Number");
                }
                
            }
        }
    }
}