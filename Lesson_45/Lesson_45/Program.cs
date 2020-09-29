using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson_45
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberTest();
            ColourTest();
            TaxTest();

            // The question should print ay numbers between 10 and 20 inclusive that are divisible by 2 (even numbers 10, 12, 14, 16, 18, 20)
            // or divisible by 3 (12, 15, 18). So output should be 10, 12, 14, 15, 16, 18, 20, which is 7 numbers.

            QuestionTest();

            // It behaved as predicted.
            
            Finish();
        }

        public static void NumberTest()
        {
            Console.WriteLine("Enter a number: ");
            double d = double.Parse(Console.ReadLine());
            bool isSingleDigit = d >= 0 && d <= 9;
            switch (isSingleDigit)
            {
                case true:
                    Console.WriteLine("It's between 0 and 9.");
                    break;

                case false:
                    Console.WriteLine("Not between 0-9.");
                    break;
            }
        }

        public static void ColourTest()
        {
            Console.WriteLine("Enter a colour: ");
            string colour = Console.ReadLine();
            bool isPrimary = colour == "red" || colour == "blue" || colour == "green";
            switch (isPrimary)
            {
                case true:
                    Console.WriteLine("It's a primary colour.");
                    break;

                case false:
                    Console.WriteLine("Not a primary colour.");
                    break;
            }
        }

        public static void TaxTest()
        {
            bool taxable = false, taxFree = false;
            taxFree = !taxable;
            Console.WriteLine("Taxable? " + taxable + ". Taxfree? " + taxFree + ".");
        }

        public static void QuestionTest()
        {
            for (int x = 10; x <= 20; x++)
            {
                if (x % 2 == 0 || x % 3 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }

        public static void Finish()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
