using System;

namespace Lesson_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            SwapFirstAndLast(array);

            Console.ReadKey();
        }

        public static void SwapFirstAndLast(int[] input)
        {
            
            int last = input[input.Length - 1];

            input[input.Length - 1] = input[0];
            input[0] = last;

            Console.WriteLine("First is now: " + input[0]);
            Console.WriteLine("Last is now: " + input[input.Length - 1]);
        }
    }
}
