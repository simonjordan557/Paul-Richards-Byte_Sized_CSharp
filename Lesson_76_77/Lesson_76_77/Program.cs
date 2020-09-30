using System;
using System.Collections.Generic;

namespace Lesson_76_77
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 76: calling Clear on a list should make the count 0.

            List<string> list = new List<string> { "this", "is", "a", "list", "of", "7", "count" };
            Console.WriteLine("This list has a count of " + list.Count);
            list.Clear();
            Console.WriteLine("After clearing, this list has a count of " + list.Count);
            Console.ReadKey();

            // It behaved as predicted.

            // Question 77: The single instance of Europe would not be removed, since the RemoveAt method only executes if the LastIndex of "Europe" is
            // greater than the first index of "Europe" - if it only appears once, the two indices are equal so the 'if' condition evaluates to false.


        }
    }
}
