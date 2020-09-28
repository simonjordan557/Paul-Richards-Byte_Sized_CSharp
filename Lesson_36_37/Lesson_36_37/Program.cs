using System;

namespace Lesson_36_37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question lesson 36: The Error List is displayed below, and can be toggled in the 'view' menu.

            // Question lesson 37: I expect the following code will throw an exception based on it being 
            // unable to parse the string into a numeric format.

            string s = "seven point five";
            double d = double.Parse(s);
            Console.WriteLine(d);
            Console.ReadKey();

            // It did throw the following exception: System.FormatException: 'Input string was not in a correct format.'
        }
    }
}
