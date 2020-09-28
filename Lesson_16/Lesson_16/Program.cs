using System;

namespace Lesson_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            if (x < 0)
            {
                Console.WriteLine("Negative");
            }

            else if (x > 0)
            {
                Console.WriteLine("Positive");
            }

            else
            {
                Console.WriteLine("Zero");
            }

            // Question: Why not use 3 sequential 'if' statements? 3 statements would require all 3 checks, even if a previous check evaluates 'true'.
            // This is inefficient. using 'else if' only conducts the minimum evaluations necessary to reach a 'true', which is more efficient. And in a method,
            // using 'else' ensures all code paths (possibilities) are considered, and return a value if necessary.

            // Checking the book, the author gives efficiency as the reasoning behind his logic, as I also stated. 

            Console.ReadKey();
        }
    }
}
