using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            float grade;
            string text_grade;
            Console.WriteLine("This is Prep 2");
            Console.WriteLine("Please type the grade percentage:");
            while(!float.TryParse(Console.ReadLine(), out grade))
            {
                Console.WriteLine("Make sure you write a number!");
            };
            text_grade="none";
            if (grade>=90)
            {
               text_grade="A"; 
            }
            else if (grade>=80 && grade <90)
            {
                text_grade="B"; 
            }
            else if (grade>=70 && grade <80)
            {
                text_grade="C"; 
            }
            else if (grade>=60 && grade <70)
            {
                text_grade="D"; 
            }
            else if (grade<60)
            {
                text_grade="F"; 
            }
            Console.WriteLine($"The corresponding grade is: {text_grade}");
        }
    }
}
