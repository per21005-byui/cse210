using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your first last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");
            // Write your code here
        }
    }
}
