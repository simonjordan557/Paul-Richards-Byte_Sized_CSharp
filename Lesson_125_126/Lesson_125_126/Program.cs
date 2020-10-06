using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_125_126
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 125: The members of an interface are automatically always public and abstract, so there is no need to lable them as such,
            // C# does it behind the scenes.

            int total = 0;
            foreach (int i in Enumerable.Range(1, 100))
            {
                total += i;
            }

            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
