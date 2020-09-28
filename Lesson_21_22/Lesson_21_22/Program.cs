using System;

namespace Lesson_21_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 21 Question: There is a method which takes a parameter: 'Console.WriteLine(sum)'

            // Lesson 22 Question: If the method requires a parameter, but no argument is provided in the call, it should result in an error.

            PrintMessage();

            // It does.


        }
        public static void PrintMessage(string message)
        {
            Console.WriteLine("Your message is: " + message);
        }
    }
}
