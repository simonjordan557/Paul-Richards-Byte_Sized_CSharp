using System;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = 2 > 1; // true
            bool y = 2 > 2; // false
            bool z = 2 >= 2; // true

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // Question: '2.5 != 3.5' should evaluate true, as they are not equal.

            bool a = 2.5 != 3.5;
            Console.WriteLine(a);

            // It did.

            Console.ReadKey();
        }
    }
}
