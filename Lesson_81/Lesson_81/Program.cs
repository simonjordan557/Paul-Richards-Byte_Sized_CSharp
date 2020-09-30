using System;

using System.Collections.Generic;

namespace Lesson_81
{
    class Program
    {
        static void Main(string[] args)
        {

            // Question 81: This code would generate squares of -10 to 10 inclusive, but since squares are always positive the values would be duplicated.
            // 'squares' would be supplied with 100, 81, 64, 49, 36, 25, 16, 9, 4, 1, 0, 1, 4, 9, 16, 25, 36, 49, 64, 81, 100.
            // I think it would ignore the duplicates. The question is, would it naturally sort them descending to ascending, in order of entry, or order of overwriting?
            // There are probably constructor overloads to specify this, maybe as an enum? Is this what the IComparer<int> is?
            // I guess it will default to ascending order, such as in Array.Sort(), so the first value will be 0.

            SortedSet<int> squares = new SortedSet<int>();

            for (int i = -10; i <= 10; i++)
            {
                squares.Add(i * i);
            }

            foreach (int i in squares)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            // I guessed correctly, it did sort according to value.
        }
    }
}
