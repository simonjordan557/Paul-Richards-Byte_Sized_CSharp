using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_131
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            foreach (string day in days.Where(s => s.Contains('r')))
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();

            foreach (string day in days.Select(s => s.ToUpper()))
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();

            // Question 131:

            foreach (string day in days.Where(s => !s.Contains('e')))
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();
        }
    }
}
