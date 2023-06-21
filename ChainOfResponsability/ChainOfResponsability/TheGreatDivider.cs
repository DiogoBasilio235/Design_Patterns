using System;

namespace ChainOfResponsability
{
    public static class TheGreatDivider
    {
        public static void MaxIntDivideBy(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) {
                throw new ArgumentException("Nothing entered", "number");
            }
            Console.WriteLine(int.MaxValue / int.Parse(number));
        }
    }
}