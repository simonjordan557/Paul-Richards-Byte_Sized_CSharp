using System;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numberOfGrainsOfSand = 10000000000000000000;
            Console.WriteLine($"The nnumber of grains of sand is: {numberOfGrainsOfSand}.");

            Console.ReadKey();
            

            // Kesson Question: 50,000 could be stored as a long, ulong, int, uint, ushort.
            // Ushort would be most memory efficient. int might be better in practicality, for compatability with other variables.
        }
    }
}
