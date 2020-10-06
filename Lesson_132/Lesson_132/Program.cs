using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_132
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> numbers2 = new List<int>() { 1, 5, 9, 11, 52, 64, 74, 80 };

            bool allSingleDigit1 = numbers.All(i => i < 10);
            Console.WriteLine(allSingleDigit1);

            bool allSingleDigit2 = numbers2.All(i => i < 10);
            Console.WriteLine(allSingleDigit2);
            Console.ReadKey();

            bool anyOver181 = numbers.Any(j => j >= 18);
            Console.WriteLine(anyOver181);

            bool anyOver182 = numbers2.Any(j => j >= 18);
            Console.WriteLine(anyOver182);
            Console.ReadKey();

            bool contains61 = numbers.Contains(6);
            Console.WriteLine(contains61);

            bool contains62 = numbers2.Contains(6);
            Console.WriteLine(contains62);
            Console.ReadKey();

            bool theSame = numbers.SequenceEqual(numbers2);
            Console.WriteLine(theSame);
            Console.ReadKey();

            // Question 132: I'd use 'Any' to see if a string had at least one upper case character.

            // This code tests all strings in an array to see if an uppercase appears anywhere in the string[]. It's a nested LINQ query!

            string[] tests = new string[] { "HELLO", "Hello", "hello" };
           
            bool hasCaps;

            hasCaps = tests.Any(s => s.Any(c => char.IsUpper(c)));

            Console.WriteLine(hasCaps);
            Console.ReadKey();

            // This one cycles through each string in the array, and evaluates each one seperately:

            foreach (string test in tests)
            {
                hasCaps = test.Any(c => char.IsUpper(c));
                Console.WriteLine($"Does {test} contain upper case characters? {hasCaps}.");
            }

            Console.ReadKey();


        }
    }
}
