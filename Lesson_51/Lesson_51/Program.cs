using System;
using System.Linq;

namespace Lesson_51
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abracadabra";
            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine();
            bool contains = s.Contains(input);
            Console.WriteLine(contains);

            Console.WriteLine("\nEnter a word to sort:");
            input = Console.ReadLine();
            OutputLetters(input);
            

        }

        public static void OutputLetters(string input)
        {
            string output = "";

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    output += c;
                }
            }

            char[] outputArray = output.ToCharArray();
            Array.Sort(outputArray);

            output = new string(outputArray);

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
