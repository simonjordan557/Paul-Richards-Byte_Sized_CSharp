using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

namespace Lesson_170
{
    class Program
    { // Can't seem to pass in a null string whatsoever?
       
        static void Main(string[] args)
        {
            
            Console.WriteLine(Right("Simon", 2));
            Console.WriteLine(Right("Jordan", 5));
            Console.WriteLine(Right("Dog", 3));
           
            Console.WriteLine(Right("Hello", -5));
            Console.WriteLine("", 0);

            Console.ReadLine();
        }

        public static string Right(string input, int? length = null)
        {
            int returnLength = length ?? 0;
            return input != null && input.Length >= returnLength && returnLength > 0 ? input.Substring(input.Length - returnLength, returnLength) : "";
        }

    }
}
