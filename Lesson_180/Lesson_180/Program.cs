using System;

namespace Lesson_180
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice;
            Random random = new Random();
            dice = random.Next(1, 7);
            Console.WriteLine(dice);
            Console.ReadLine();

        }
    }
}
