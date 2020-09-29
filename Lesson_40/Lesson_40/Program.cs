using System;

namespace Lesson_40
{
    class Program
    {

        // Pressing F5 a second time continues execution past the breakpoint, so triggered the exception on that line.
        static void Main(string[] args)
        {
            int[] theArray = new int[0];
            WriteFirst(theArray);
        }

        public static void WriteFirst(int[] array)
        {
            Console.WriteLine("The first array element is: " + array[0]);
        }
    }
}
