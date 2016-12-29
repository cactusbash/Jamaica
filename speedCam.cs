using System;

namespace SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Console.WriteLine("*   Made by D - 2016   *");
            Console.WriteLine("************************");
            Console.WriteLine(" ");

            Console.WriteLine("Enter the vehicle's speed:");
            var speed = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Enter the speed limit:");
            var speedLimit = Console.ReadLine();
            Console.WriteLine(" ");

            int Speed = Convert.ToInt32(speed);
            int SpeedLimit1 = Convert.ToInt32(speedLimit);

            if (Speed <= SpeedLimit1)
                Console.WriteLine("PASS");
            else
            {
                int demPoints = (Speed - SpeedLimit1);
                if (demPoints < 12 )
                    Console.WriteLine((demPoints+1) + "Demerit Points");
                else
                    Console.WriteLine("Suspended License - POLICE GONNA GETCHU");
            }

        }
    }
}
