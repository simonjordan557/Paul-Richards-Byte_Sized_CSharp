using System;

namespace Lesson_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend:");
            string dividendString = Console.ReadLine();

            Console.WriteLine("Enter the divisor:");
            string divisorString = Console.ReadLine();

            int dividend = int.Parse(dividendString);
            int divisor = int.Parse(divisorString);

            if (divisor == 0)
            {
                Console.WriteLine("You cannot divide by zero");
            }

            else
            {
                int quotient = dividend / divisor;
                Console.WriteLine("Quotient = " + quotient);

                int remainder = dividend % divisor;
                if (remainder > 0)
                {
                    Console.WriteLine("Remainder = " + remainder); 
                }
            }

            // Question: 6 / 2 would output: "Quotient = 3"
            //           6 / 4 would output: "Quotient = 1 Remainder = 2"
            //           6 / 0 would output: "You cannot divide by zero"

            Console.ReadKey();
        }
    }
}
