using System;
using System.Linq;

namespace Lesson_38
{
    class Program
    {
        static void Main(string[] args)
        {

            // The major disadvantage of returning a special value such as -1 instead of an exception is that
            // you might not even know there was a problem, as the program continues to run. Therefore the problem 
            // is never fixed, the program may continue to run with garbage data that is further processed, causing bigger 
            // problems down the line that are harder to trace back to the source.

            double[] arr = new double[0];
            Console.WriteLine(Range(arr));
            Console.ReadKey();
        }

        public static double Range(double[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values cannot be null.");
            }

            if (values.Length == 0)
            {
                throw new ArgumentException("values cannot be empty.");
            }

            return values.Max() - values.Min();
        }
    }
}
