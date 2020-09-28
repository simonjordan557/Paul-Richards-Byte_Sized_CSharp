using System;
using System.Net.Http.Headers;

namespace Lesson_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a traffic light colour:");
            string colour = Console.ReadLine();

            switch (colour)
            {
                case "red":
                    Console.WriteLine("STOP!");
                    break;
                case "yellow":
                    Console.WriteLine("Get ready...");
                    break;
                case "green":
                    Console.WriteLine("GO!");
                    break;
                default:
                    Console.WriteLine("Colour not recognised.");
                    break;
            }

            Console.WriteLine("Enter an animal:");
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                case "cat":
                    Console.WriteLine("Stroke it.");
                    break;

                case "spider":
                case "fly":
                    Console.WriteLine("Squish it!");
                    break;

                default:
                    Console.WriteLine("Run away!");
                    break;
            }

            // Question: 'True or False? When a switch statement is encountered, one of the code blocks MUST be executed'.
            // I think this is false, as 'default' keyword is not required, and 'case' statement is an 'if', so if all 'case' evaluate false, no code blocks will execute.

            int x = 10;

            switch (x)
            {
                case 1:
                    Console.WriteLine("Executing first code block");
                    break;
                case 2:
                    Console.WriteLine("Executing second code block");
                    break;
            }

            Console.WriteLine("Outside switch statement now.");

            // It worked as expected.

            Console.ReadKey();

        }
    }
}
