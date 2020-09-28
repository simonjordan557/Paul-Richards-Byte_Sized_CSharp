using System;

namespace Lesson_7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 7 question: I'd use decimal to store a monetary amount as it's the most accurate of the non-integer types.

            decimal priceBeforeTax = 100;
            decimal tax = 20;
            decimal price = priceBeforeTax - tax;
            Console.WriteLine(price);

            // Integer division vs non-integer division

            int x = 2 / 3;
            Console.WriteLine(x);

            double y = 2.0 / 3;
            Console.WriteLine(y);

            double z = 2d / 3.0;
            Console.WriteLine(z);

            // Question: 'int x = -5 / 3': I *think* this will evaluate to -1?

            int a = -5 / 3;
            Console.WriteLine(a);
            Console.ReadKey();

            // It did!

        }
    }
}
