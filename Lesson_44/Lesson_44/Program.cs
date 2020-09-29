using System;

namespace Lesson_44
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            foreach(string s in days)
            {
          
                Console.WriteLine(s);
            }

            Console.ReadKey();

            // Question advantages of 'foreach' over 'for':
            // - Cleaner code
            // - Easier to read
            // - No chance of making a mistake with initialisation or condition as with 'for' loop.
            // - However I don't think 'foreach' loop can modify the variable?
            // - I was right - Cannot assign to foreach iteration variable.
        }
    }
}
