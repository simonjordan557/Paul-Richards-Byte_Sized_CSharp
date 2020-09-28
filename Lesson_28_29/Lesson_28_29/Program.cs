using System;

namespace Lesson_28_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daysInMonth;
            daysInMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Question lesson 28: Which index of the array holds the value 28? I predict index 1.
            Console.WriteLine(Array.IndexOf(daysInMonth, 28));

            // Prediction was correct.

            // Question lesson 29: Create an array containing 10 double values

            double[] doubleArray = new double[10];

            Console.ReadKey();
        }
    }
}
