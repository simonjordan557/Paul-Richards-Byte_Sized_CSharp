using System;

namespace Lesson_54
{
    class Program
    {

        // I predict this program will keep doubling 'x' until it hits 256, so:
        // 1, 2, 4, 8, 16, 32, 64, 128, 256.
        static void Main(string[] args)
        {
            for (int x = 1; x <= 256; x *= 2)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    } // It behaved as predicted.
}
