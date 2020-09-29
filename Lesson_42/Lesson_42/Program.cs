using System;

namespace Lesson_42
{
    class Program
    {

        // Note - the book states this loop executes 10 times, but also correctly states it displays 0-10 inclusive, which is 11 executions.
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
