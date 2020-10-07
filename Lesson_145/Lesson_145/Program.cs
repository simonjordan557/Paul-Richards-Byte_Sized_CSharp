using System;

namespace Lesson_145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Peter", "Piper", "picked", "a", "peck", "of", "pickled", "peppers" };

            string joined = string.Join(' ', arr);

            // Question 145:

            int[] dateArray = { 23, 3, 1973 };
            string dateString = string.Join('/', dateArray);
        }
    }
}
