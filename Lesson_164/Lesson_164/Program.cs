using System;

namespace Lesson_164
{
    class Program
    {
        // Question 164: For readability, the automatically defined Item1, Item2, etc. are not very descriptive.
        static void Main(string[] args)
        {
            string name = "simon";
            Tuple<char, int> result = FirstVowel(name);

            Console.WriteLine($"The vowel '{result.Item1}' appears at position {result.Item2}.");
            Console.ReadLine();

        }

        public static Tuple<char, int> FirstVowel(string s)
        {
            if (s != null)
            {


                for (int i = 0; i < s.Length; i++)
                {
                    if ("aeiou".Contains(s[i]) || "AEIOU".Contains(s[i]))
                    {
                        return new Tuple<char, int>(s[i], i);
                    }
                }
            }

            return null;
        }
    }
}
