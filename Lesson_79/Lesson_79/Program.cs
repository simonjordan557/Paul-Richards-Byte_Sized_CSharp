using System;
using System.Collections.Generic;

namespace Lesson_79
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            // Although Dictionary keys need to be unique (Like indices in an array, or a HashSet), values should be able to repeated.
            // i.e. If the values were bank balances, or ranks, they could re-occur. in the same way that int x = 3 and int y = 3 is OK.

            phoneBook["Tom"] = "001";
            phoneBook["Dick"] = "002";
            phoneBook["Harry"] = "002";

            string name = "Harry";
            Console.WriteLine(name + " has a number of " + phoneBook[name]);
            name = "Dick";
            Console.WriteLine(name + " has a number of " + phoneBook[name]);

            Console.ReadKey();

            // It worked as predicted.

        }
    }
}
