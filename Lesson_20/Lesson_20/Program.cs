using System;

namespace Lesson_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -5;
            int b = 7;
            double c = 4.76;
            decimal d = 0.67m;
            string s = "hello";

            Print(a);
            Print(b);
            Print(c);
            Print(d);
            Print(s);

            Console.ReadKey();
        }
        public static void Print(Object o)
        {
            switch (o)
            {
                case int i when i < 0:
                    Console.WriteLine("Negative integer: " + i);
                    break;
                case int i when i >= 0:
                    Console.WriteLine("Positive integer: " + i);
                    break;
                case double d:
                    Console.WriteLine("Double: " + d);
                    break;
                case decimal m:
                    Console.WriteLine("Decimal: " + m);
                    break;
                default:
                    Console.WriteLine("Unrecognised type.");
                    break;
            }
        }

        // Question: supplying a string as an argument would result in the default code block executing.
        // There is no specific pattern variable case that deals with the supplied object being a string.

        // This executed as expected.
    }

   
}
