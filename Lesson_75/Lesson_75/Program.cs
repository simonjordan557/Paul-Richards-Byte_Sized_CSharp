using System;
using System.Collections.Generic;
namespace Lesson_75
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Hello", "this", "is", "a", "list", "of", "strings", "the", "program", "below", "will", "try", "to", "find", "all", "appearances", "of", "the", "word", "the" };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "the")
                {
                    Console.WriteLine("\"the\" is present at index " + i + ".");

                }
            }

            Console.ReadKey();

        }
    }
}
