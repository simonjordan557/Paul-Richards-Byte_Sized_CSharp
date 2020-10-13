using System;

namespace Lesson_161
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test1 = new Test();
            test1.a = 1;
            test1.b = 2;

            Test test2 = new Test();
            test2.a = 1;
            test2.b = 2;

            Console.WriteLine($"EQUALS: {test1.Equals(test2)}");

            Console.WriteLine($"==: {test1 == test2}");
        }
    }
}
