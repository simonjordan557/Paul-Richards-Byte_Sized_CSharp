using System;

namespace Lesson_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OutputCharacterReverse("Hello World!"));
            Console.ReadKey();
        }

        public static string OutputCharacterReverse(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result = result + s[i];
            }

            return result;
        }


    }
}
