using System;

namespace Lesson_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            if (x == y)
            {
                Console.WriteLine("The two numbers are equal.");
            }

            else
            {
                Console.WriteLine("The two numbers are not equal.");
            }

            // Question: I predict the code will state "Greater than or equal" as the 'if' comparison evaluates true so ignores the 'else' block.

            if (4.5 >= 4)
            {
                Console.WriteLine("Greater than or equal");
            }

            else
            {
                Console.WriteLine("NOT greater than or equal");
            }

            // I was correct. Again, the same 'unreachable' code error form Visual Studio due to hardcoded literals in the 'if' comparison

            Console.ReadKey();
        }
    }
}
