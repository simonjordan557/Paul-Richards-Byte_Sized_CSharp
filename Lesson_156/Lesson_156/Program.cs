using System;

namespace Lesson_156
{
    class Program
    {
        // Question 156: strings are reference types.
        static void Main(string[] args)
        {
            int x = 1000;
            Console.WriteLine($"x before method: {x}");
            TestValue(x);
            Console.WriteLine($"x after method: {x}");
            Console.ReadLine();

            Numbers numbers = new Numbers();
            Console.WriteLine($"numbers before method: {numbers}");
            TestReference(numbers);
            Console.WriteLine($"numbers after method: {numbers}");
            Console.ReadLine();
        }

        public static void TestValue(int i)
        {
            Console.WriteLine($"i at start of method: {i}");
            i++;
            Console.WriteLine($"i at end of method: {i}");
        }

        public static void TestReference(Numbers input)
        {
            Console.WriteLine($"input at start of method: {input}");
            input.a++;
            input.b++;
            Console.WriteLine($"input at end of method: {input}");
        }

    }
}
