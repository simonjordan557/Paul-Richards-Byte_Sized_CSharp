using System;

namespace Lesson_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of your square: ");
            int length = int.Parse(Console.ReadLine());
            int area = Area(length);
            Console.WriteLine("\nThe area is: " + area);
            Finish();
        }

        public static int Area(int d)
        {
            return d * d;
        }

        public static void Finish()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
