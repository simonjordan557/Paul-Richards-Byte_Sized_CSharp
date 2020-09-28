using System;

namespace Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder = 15 % 7;
            Console.WriteLine(remainder);

            // Question: I predict 'int remainder = 15 % 5;' will return 0.

            int newRemainder = 15 % 5;
            Console.WriteLine(newRemainder);

            Console.ReadKey();

            // It did!

        }
    }
}
