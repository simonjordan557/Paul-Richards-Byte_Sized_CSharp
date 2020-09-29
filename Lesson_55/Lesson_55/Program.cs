using System;

namespace Lesson_55
{
    class Program
    {
        static void Main(string[] args)
        {
            // I think this would compile, but it won't output any " characters.
            string s = "" + "I think therefore I am" + "" + " - Descartes";
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
