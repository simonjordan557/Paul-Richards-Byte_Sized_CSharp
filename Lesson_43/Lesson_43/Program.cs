using System;
using System.Xml;

namespace Lesson_43
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            OutPut(days);
            Finish();
        }
        /// <summary>
        /// Outputs all values from array to the console, in reverse order.
        /// </summary>
        /// <param name="input">the string array to output to the console</param>
        public static void OutPut(string[] input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }
        }

        public static void Finish()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
