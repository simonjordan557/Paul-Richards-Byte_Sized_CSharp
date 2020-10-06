using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_139
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert IEnumerable to a list if it is iterated over multiple times.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> sortedNumbers = numbers.OrderByDescending(i => i).Skip(3).ToList();

            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();

            // Question 139: The method in the book checks the first index, and if it finds that value in a new IEnumerable remaining index, returns true.
            // It checks the last index, and if it finds that value in any previous index, returns true. 
            // So that's at least four sweeps of the IEnumerable collection each call. So better to use ToArray() or ToList().
        }
    }
}
