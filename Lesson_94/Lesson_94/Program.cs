using System;

namespace Lesson_94
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writes out the times tables

            // I fixed the code by providing the inner loop with the 'j' identifier, so it wasn't re-using the calue of 'i' from the outer loop.

            Console.WriteLine("x\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10\t11\t12");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"\n\n\n{i}");

                for (int j = 1; j <= 12; j++)
                {
                    Console.Write($"\t{i * j}");
                }

            }

            Console.ReadKey();
        }
    }
}
