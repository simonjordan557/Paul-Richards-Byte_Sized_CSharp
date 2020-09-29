using System;

namespace Lesson_41
{
    class Program
    {
        static void Main(string[] args)
        {
            // I predict this loop will never execute, as 'i' is initialised then immediately evaluates false in the condition check.

            for (int i = 0; i < 0; i = i + 1)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            // It behaved as expected.
        }
    }
}
