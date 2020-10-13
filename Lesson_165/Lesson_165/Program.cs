using System;

namespace Lesson_165
{
    class Program
    {   // Question 165: ValueTuple is a value type so not nullable - I had to use the ? operator to make it nullable. Also, I can't seem to access the results using
        // Item1, Item2 anymore.
        static void Main(string[] args)
        {
            string name = "simon";
            var result = FirstVowel(name);
            Console.ReadLine();
        }

        public static (char, int)? FirstVowel(string s)
        {
            if (s != null)
            {


                for (int i = 0; i < s.Length; i++)
                {
                    if ("aeiou".Contains(s[i]) || "AEIOU".Contains(s[i]))
                    {
                        return (s[i], i);
                    }
                }
            }

            return null;
        }
    }
}
