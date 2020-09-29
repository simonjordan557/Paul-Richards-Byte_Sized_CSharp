using System;

namespace Lesson_46
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 187, 154.6, 34.7, 122, -0.54 };
            int result = FindFirstPercentage(numbers);
            Console.WriteLine("The first index which could be a percentage is index " + result + ".");
          
            double fahrenheit = 100.8;
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine(fahrenheit + " fahrenheit is " + celsius + " celsius.");
            Console.ReadKey();
        }

        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) / 1.8;
        }

        public static int FindFirstPercentage(double[] input)
        {
            int index = 0;
            while (index < input.Length && (input[index] < 0 || input[index] > 100))
            {
                index++;
            }

            if (index >= input.Length)
            {
                return -1;
            }

            return index;
        }
    }
}
