using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "deez";
            var lastName = "dee";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Lara", "Rose", "June" };
            var formattedNames = string.Join(",", names);

            var text2 = "Hi Lara\nLook into these folders\nC:\\folder1\\folder2\nC:\\folder3\\folder4";
            var text = @"Hi Lara
Look into the following paths
c:\folder1\folder2
c:\\folder3\\folder4";

            Console.WriteLine(text);
            Console.WriteLine(text2);
            Console.WriteLine(myFullName + " " + "HELLO");
        }
    }
}
