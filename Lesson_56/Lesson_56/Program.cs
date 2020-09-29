using System;

namespace Lesson_56
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Temp\test.txt";
            string s = "C:\\Temp\\test.txt";
            Console.WriteLine(fileName);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
