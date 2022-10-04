using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 4");
            List<int> numberList = new List<int>();
            bool exitSignal = false;
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            while (exitSignal==false)
            {
                int inputNumber;
                inputNumber=verifiedIntInputFromConsole("Enter Number:");
                if (inputNumber!=0)
                {
                    numberList.Add(inputNumber);
                } else {
                    exitSignal=true;
                }
            }
            float sumOfList=0;
            float averageOfList;
            int largestNumberInList=0;
            foreach (int item in numberList)
            {
                if (item>largestNumberInList)
                {
                    largestNumberInList=item;
                }
                sumOfList = sumOfList+item;
            }
            averageOfList = sumOfList/numberList.Count;

            Console.WriteLine($"The sum is: {sumOfList}");
            Console.WriteLine($"The average is: {averageOfList}");
            Console.WriteLine($"The largest number is: {largestNumberInList}");
        }
        static int verifiedIntInputFromConsole(string message)
        {
            int returnInteger;
            Console.WriteLine(message);
            while(!int.TryParse(Console.ReadLine(), out returnInteger))
            {
                Console.WriteLine("Make sure you write a number!");
            };
            return returnInteger;
        }
    }
}
