using System;

namespace Lesson_47
{
    class Program
    {
        static void Main(string[] args)
        {


            uint[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 23, 45, 76, 76, 34, 654 };
            bool result = ReachesTarget(numbers, 100);
            Console.WriteLine(result);
            Console.ReadKey();
                

        }
        /// <summary>
        /// Checks to see if all elements of an array add up to at least the target.
        /// </summary>
        /// <param name="array">the array to total</param>
        /// <param name="target">does it reach this target?</param>
        /// <returns>true if it does add up to the target, false if not</returns>
        /// 

        // Question: while loop is better than for loop, because while loop only executes as long as it needs to, whereas for loop
        // will needlessly continue looping through the array until the end, even if it already hit 100.
        public static bool ReachesTarget(uint[] array, uint target)
        {
            uint total = 0;
            int i = 0;

            while (total < target && i < array.Length)
            {
                total += array[i];
                i++;
            }

            return total >= target;
        }
    }
}
