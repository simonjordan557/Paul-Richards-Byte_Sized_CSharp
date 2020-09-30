using System;
using System.Collections.Generic;

namespace Lesson_78
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<char> characterSet = new HashSet<char>();
            characterSet.Add('B');
            characterSet.Add('A');
            characterSet.Add('N');
            characterSet.Add('A');
            characterSet.Add('N');
            characterSet.Add('A');

            foreach (char c in characterSet)
            {
                Console.WriteLine(c);
            }

            char toRemove = 'A';

            while (characterSet.Count > 1)
            {
                characterSet.Remove(toRemove);
                Console.WriteLine("\nRemoved " + toRemove + "\n");
                foreach (char c in characterSet)
                {
                    Console.WriteLine(c);
                }

                toRemove = (char)(toRemove + 1);
            }

            Console.ReadKey();

        }
    }
}
