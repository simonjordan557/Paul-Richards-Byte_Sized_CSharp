using System;
using System.Text.RegularExpressions;

namespace Lesson_150
{
    class Program
    {

        // Question 150: The main disadvantage of regular expressions is they are not very human-readable which makes them hard to understand and debug,
        // and easy to make mistakes with whilst coding. 

        static void Main(string[] args)
        {
            string s = "1 2 skip a few 99 100";
            Regex regex = new Regex(@"\d");
            foreach (Match m in regex.Matches(s))
            {
                Console.WriteLine(m.Value + " found at index: " + m.Index);
            }
        }
    }
}
