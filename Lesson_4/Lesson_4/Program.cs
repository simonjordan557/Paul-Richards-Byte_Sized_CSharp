using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Paul";
            Console.WriteLine(name);

            name = "Steve";
            Console.WriteLine(name);

            Console.ReadLine();

            // In the end-of-lesson question, the quoted code wouldn't work as the string 'name' is declared but not initialised before the first Console.WriteLine.
        }
    }
}
