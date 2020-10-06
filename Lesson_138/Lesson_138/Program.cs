using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_138
{
    class Program
    {
        static void Main(string[] args)
        {

            // Question 138: Not sure which var SQL will return. LINQ would return an IEnumerable, but the parameter is a string[] so would
            // SQL return a string[]? I think this is unlikely, there's no use of the 'new' keyword, but it could be done implicitly.

            // Answer: It returns an IOrderedEnumerable. So a more specific type of IEnumerable than what LINQ returns?
            // the book answer confirms that this is a sub-interface of IEnumerable. So interfaces themselves can be inherited?

            string[] arr = { "white", "red", "yellow", "green", "brown", "blue", "pink", "black" };

            var orderedStrings = from s in arr orderby s.Last(), s.Length descending select s;

            foreach (string s in orderedStrings)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
