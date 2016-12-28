using System;


namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 267;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's Morrning...");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("its the PM...");
            else
                Console.WriteLine("ITS NIGHT...");
        }
    }
}
