using System;

namespace Lesson_179
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -5;
            Console.WriteLine(Math.Sign(a));

            Console.WriteLine(Math.Abs(a));

            int b = 6;
            Console.WriteLine(Math.Max(a, b));

            Console.WriteLine(Math.Min(a, b));

            double c = 1.123456789;
            Console.WriteLine(Math.Round(c, 3));

            // I predict this will return an error as a square is always positive:

            Console.WriteLine(Math.Sqrt(-1));

            // It compiled and ran but returned NaN.

            Console.ReadLine();


        }
    }
}
