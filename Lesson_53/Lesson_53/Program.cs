using System;

namespace Lesson_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            double d = double.Parse(input);
            double square = d * d;
            Console.WriteLine("The square of " + d + " is: " + square + ".");
            Console.ReadKey();
        }
    }
}
