using System;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2147483647;
            int y = x + 1;
            Console.WriteLine(y);

            // Overflowed because it went past the upper limit of the type

            long z = x + 1;
            Console.WriteLine(z);

            // Still overflowed as the right side of the operation added two ints together which overflowed, THEN stored the result in a long.
            // Would need to involve a long in the right side of the operation.

            // Question: I predict using uints and then generating a number less than 0 would overflow back to the maximum value of 2E32.

            uint a = 0;
            uint b = a - 1;
            Console.WriteLine(b);

            Console.ReadKey();

            // It did!
        }
    }
}
