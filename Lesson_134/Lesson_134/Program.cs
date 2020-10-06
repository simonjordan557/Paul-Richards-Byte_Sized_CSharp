using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_134
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cabbage";

            Console.WriteLine("Prediction: age\n");
            foreach (char c in s.Skip(4))
            {
                Console.Write(c);
            }
            Console.ReadLine();

            Console.WriteLine("Prediction: cabba\n");
            foreach (char c in s.SkipLast(2))
            {
                Console.Write(c);
            }
            Console.ReadLine();

            Console.WriteLine("Prediction: abbage\n");
            foreach (char c in s.SkipWhile(c => c == 'c'))
            {
                Console.Write(c);
            }
            Console.ReadLine();

            Console.WriteLine("Prediction: cab\n");
            foreach (char c in s.Take(3))
            {
                Console.Write(c);
            }
            Console.ReadLine();

            Console.WriteLine("Prediction: ge\n");
            foreach (char c in s.TakeLast(2))
            {
                Console.Write(c);
            }
            Console.ReadLine();

            Console.WriteLine("Prediction: c\n");
            foreach (char c in s.TakeWhile(c => c == 'c'))
            {
                Console.Write(c);
            }
            Console.ReadLine();

            // Question 134: Skipping more items than there are in the IEnumerable might result in an OutOfRange exception? Less likely, it might return null.

            System.Text.StringBuilder newString = new System.Text.StringBuilder();


            foreach (char c in s.Skip(8))
            {
                Console.WriteLine(c);
                newString.Append(c);
            }

            string returnedString = newString.ToString();
            Console.WriteLine(returnedString);
            Console.ReadLine();

            // No exception was triggered, it just returned an empty IEnumerable, I think. Tested by using a stringBuilder, which just returns empty.
        }
    }
}
