using System;

namespace Lesson_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "everyone";
            string c = "!";

            string result = Concatenate(a, b, c);
            Console.WriteLine(result);
            Finish();
        }

        // Question: removing the '[]' from the method header should result in an error, because multiple string input has to be parsed into an array by params,
        // not a single string.

        // As expected, error stated that paprameter must be at least a single dimensional array, and I couldn't pass multiple arguments in my method call.

        public static string Concatenate(params string[] values)
        {
            return string.Join(", ", values);
        }

        public static void Finish()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
