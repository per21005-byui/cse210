using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 100);
            int attempt=0;
            Console.WriteLine("------------------");
            Console.WriteLine("| This is Prep 3 |");
            Console.WriteLine("------------------");
            Console.WriteLine("A random number has been generated");
            Console.WriteLine("-------------------");
            Console.WriteLine("| Ok, let's play. |");
            Console.WriteLine("-------------------");
            while(randomNumber!=attempt)
            {
                attempt = verifiedIntInputFromConsole("What is your guess?");
                if (attempt == randomNumber)
                {
                    Console.WriteLine("Yay! you made it!");
                }
                else if (attempt<randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (attempt>randomNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
        }
        static int verifiedIntInputFromConsole(string message)
        {
            int returnInteger;
            Console.WriteLine(message);
            while(!int.TryParse(Console.ReadLine(), out returnInteger))
            {
                Console.WriteLine("Make sure you write an integer!");
            };
            return returnInteger;

        }
    } 
}
