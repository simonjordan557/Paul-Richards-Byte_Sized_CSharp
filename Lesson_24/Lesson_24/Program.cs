using System;

namespace Lesson_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int b = int.Parse(Console.ReadLine());

            Maximum(a, b);
            Finish();

        }

        public static void Maximum(int a, int b)
        {
            if (a == b)
            {
                return;
            }

            else if (a > b)
            {
                Console.WriteLine(a + " is bigger than " + b);
            }

            else
            {
                Console.WriteLine(b + " is bigger than " + a);
            }
        }

        public static void Finish()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
