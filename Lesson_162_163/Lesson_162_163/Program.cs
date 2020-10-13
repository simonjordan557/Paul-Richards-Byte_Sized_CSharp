using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson_162_163
{
    class Program
    {

        // Question 163: Favourite Colour could've been implemented as a string; but enum limits the valid responses to certain ones pre-selected by the programmer.
        // Good for input error management.
        static void Main(string[] args)
        {
            Test test1 = new Test("Simon", 27, Test.Colours.red);
            Console.WriteLine(test1);
            Console.ReadLine();

        }
    }
}
