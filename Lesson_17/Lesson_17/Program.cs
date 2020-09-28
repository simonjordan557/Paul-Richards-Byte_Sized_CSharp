using System;

namespace Lesson_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "7.5";
            string t = "10";
            double x = double.Parse(s);
            int y = int.Parse(t);

            Console.WriteLine(x);
            Console.WriteLine(y);

            // Question: Here is my code that takes a user-supplied string, converts it to a double, then tells the user whether it's positive, negative, or zero.

            Console.Clear();
            Console.WriteLine("Please enter a number:");

            string input = Console.ReadLine();

            double inputAsNumber = double.Parse(input);

            if (inputAsNumber < 0)
            {
                Console.WriteLine("Negative");
            }

            else if (inputAsNumber > 0)
            {
                Console.WriteLine("Positive");
            }

            else
            {
                Console.WriteLine("Zero");
            }

            Console.ReadKey();
        }
    }
}
