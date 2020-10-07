using System;

namespace Lesson_144
{
    class Program
    {
        static void Main(string[] args)
        {
            string potusAddress = "Thw White House,1600 Pennsylvania Avenue NW,Washington,DC 20500,USA";
            string[] addressLines = potusAddress.Split(',');


            // Question 144: I predict the array will consist of "Paul", "", "Richards".

            string toSplit = "Paul,,Richards";
            string[] arr = toSplit.Split(',');

            // I was right, a way to rectify this would be to use the overloaded method which takes the enum parameter StringSplitOptions.RemoveEmptyEntries.
        }
    }
}
