using System;

namespace Lesson_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jagged = new string[3][];

            jagged[0] = new string[2];
            jagged[0][0] = "Peter";
            jagged[0][1] = "Piper";

            jagged[1] = new string[3];
            jagged[1][0] = "picked";
            jagged[1][1] = "a";
            jagged[1][2] = "peck";

            jagged[2] = new string[3];
            jagged[2][0] = "of";
            jagged[2][1] = "pickled";
            jagged[2][2] = "peppers";

            string firstName = jagged[0][0];
            string lastName = jagged[0][1];

            int howManySubArrays = jagged.Length;
            int totalElements = 0;

            for (int i = 0; i < howManySubArrays; i++)
            {
                totalElements += jagged[i].Length;
            }

            Console.WriteLine("Total elements: " + totalElements);
            Console.ReadKey();
        }

    }
}
