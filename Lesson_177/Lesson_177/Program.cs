using System;

namespace Lesson_177
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 177: I predict the code below will result in a DivideByZero exception, as '1' and '0' should be evaluated as int.

            Console.WriteLine(1 / 0);

            // Doesn't even compile, Visual Studio detects the mistake.
        }
    }
}
