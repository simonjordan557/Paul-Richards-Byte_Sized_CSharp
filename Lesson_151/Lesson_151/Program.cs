using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_151
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IEnumerable<ulong> Collatz(ulong n)
        {
            while(true)
            {
                yield return n;

                if (n == 1)
                {
                    yield break;
                }

                if (n % 2 == 0)
                {
                    n /= 2;
                }

                else
                {
                    n = 3 * n + 1;
                }
            }
        }
    }
}
