using System;

namespace Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            if (y > x) Console.WriteLine("Greater");

            // Question: I predict the following code outputs nothing, as the if statement evaluates false so the code block isn't executed.

            if (5 <= 4) Console.WriteLine("Less than");

            // I was correct. Visual Studio also flagged it up as unreachable code, knowing the two literals would never change so would never evaluate true.
            
            Console.ReadKey();
        }
    }
}
