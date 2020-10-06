using System;

namespace Lesson_128
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funch<int, int, int> funcywunc = Add;
            Func<int, int, int> funcywunc = (a, b) => a + b;

            int x = 2;
            int y = 3;

            int sum = funcywunc(x, y);

            Console.WriteLine(sum);

            Console.ReadKey();

            // Question 128

            Func<int, int, int, int> func = (a, b, c) =>
            {
                int[] array = new int[] { a, b, c };
                Array.Sort(array);
                return array[1];
            };

            int j = 2;
            int k = 7;
            int l = 3;

            int sum2 = func(j, k, l);

            Console.WriteLine(sum2);
            Console.ReadKey();

        }

       // public static int Add(int a, int b)
        //{
         //   return a + b;
       // }
    }
}
