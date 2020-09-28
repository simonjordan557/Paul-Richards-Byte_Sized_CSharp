using System;
using System.Data;

namespace Lesson_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // The function as written in the book does not seem to work. It always returns 1, which is technically correct,
            // but even returns it when it isn't passed in as an argument. the 'while' loop in EuclidGCD will only exit with 0 or 1, afaict.

            // Question: the disadvantages of local functions:

            // - Can't be accessed from outside the enclosing function
            // - Harder to follow code within code - leads to more coupling.

            // These reasons were what the author mentioned as well!

            Console.WriteLine(GCD(14, 3, 7));
        }

        public static int GCD(params int[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0;
            }

            int result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                result = EuclidGCD(result, values[i]);
            }

            return result;

            int EuclidGCD(int a, int b)
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a = a % b;
                    }

                    else
                    {
                        b = b % a;
                    }
                }

                // Don't understand what this means.
                // I *think* it means, if 'a == 0' evaluates true, return b; if not, return a.
                return a == 0 ? b : a;
            }
        }
    }
}
