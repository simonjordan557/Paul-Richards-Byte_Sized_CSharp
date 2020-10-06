using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_130
{
    class Program
    {
        static void Main(string[] args)
        {

            // I expect this will result in a compiler error, as Intellisense told me it would! This method only works if the Ienumerable is null or has 1 entry.
            // It does work when passing in a function as a parameter to check for a condition, i.e. (s => s == 3.0f), the bool s == 3.0f returns true for 1 entry, 
            // so Single is satisfied and returns 3.0f. for (s => s == 2.9f) the bool s == 2.9f evaluates false so returns default, which for a float is 0. But
            // at least it doesn't throw an exception.

            // But overall, Single is inefficient because it still has to continue searching the IEnumerable for any subsequent occurences of that bool 
            // evaluating to true. If possible, use FirstOrDefault().

            List<float> numbers = new List<float>() { 0.5f, 1.0f, 1.5f, 2.0f, 2.5f, 3.0f };

           float number = numbers.SingleOrDefault();

            Console.WriteLine(number);
            Console.ReadKey();


        }
    }
}
