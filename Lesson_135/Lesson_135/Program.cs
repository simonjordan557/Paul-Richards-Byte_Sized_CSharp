using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_135
{
    class Program
    {


        // Question 135: Using Cast() instead of OfType() throws an exception when the cast fails. So Cast would need to be used within a 'try' block, or maybe 
        // using an 'if' statement? NO DOESN'T WORK - Cast() does not return a bool. TypeOf() seems to be the far superior option.
        static void Main(string[] args)
        {
            object[] things = new object[] { "Hello", 1.5f, 2.33, 6, 'f', 9, 4.56M, "Yo", 75 };

            foreach (int i in things.OfType<int>())
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine(); 

        }

        
    }
}
