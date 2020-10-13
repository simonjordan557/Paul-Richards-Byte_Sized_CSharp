using System;

namespace Lesson_158
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 98, 23, 76, 2, 100 };
            ref int min = ref GetMin(numbers);
            Console.WriteLine($"min = {min}");
            min = 1000;
            Console.WriteLine($"min = {min}");
            Console.WriteLine(string.Join(", ", numbers));
            Console.ReadLine();

            ref int max = ref GetMax(numbers);
            Console.WriteLine($"max = {max}");
            max = 333;
            Console.WriteLine($"max = {max}");
            Console.WriteLine(string.Join(", ", numbers));
            Console.ReadLine();
        }

        public static ref int GetMin(int[] arr)
        {
            int pos = -1;
            int? min = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!min.HasValue || arr[i] < min)
                {
                    min = arr[i];
                    pos = i;
                }
            }
            return ref arr[pos];
        }

        public static ref int GetMax(int[] arr)
        {
            int pos = -1;
            int? max = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!max.HasValue || arr[i] > max)
                {
                    max = arr[i];
                    pos = i;
                }
            }
            return ref arr[pos];
        }
    }
}
