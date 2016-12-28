using System;

namespace GuessingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("* This will identify which number is bigger *");
            Console.WriteLine("*********************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Enter your first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("This number wins:");
            Console.WriteLine((firstNumber > secondNumber) ? firstNumber:secondNumber);
        }
    }
        }

