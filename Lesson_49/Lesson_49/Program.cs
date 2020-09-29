using System;

namespace Lesson_49
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char letter = 'z'; letter >= 'a'; letter = (char)(letter - 1))
            {
                Console.WriteLine(letter);
            }

            Console.ReadKey();
        }
    }
}
