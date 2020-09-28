using System;
using System.Xml.Schema;

namespace Lesson_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            string[,] colours = { { "red", "green" }, { "blue", "purple" } };

            bool[,] ticTacToe = { { true, true, true, }, { false, false, false, }, { true, false, true } };

            string[][] jagged = { new string[] { "Peter", "Piper" }, new string[]{ "picked", "a", "peck" }, new string[]{ "of", "pickled", "peppers" } };

            // Question: can you have a zero-length array? Well yes, zero is an integer - but why would you?

            int[] zeroLengthArray = { };
            double[] whyDoesThisExist = new double[0];


        }
    }
}
