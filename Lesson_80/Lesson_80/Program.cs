using System;
using System.Collections.Generic;

namespace Lesson_80
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<string>> alphabeticalFood = new Dictionary<char, List<string>>
            {
                ['a'] = new List<string> { "apple", "avocado" },
                ['b'] = new List<string> { "banana" },
                ['c'] = new List<string> { "clementine", "courgette", "cucumber" }
            };

            

            Console.ReadKey();
        }
    }
}
