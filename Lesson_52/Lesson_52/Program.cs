using System;

namespace Lesson_52
{
    class Program
    {
        static void Main(string[] args)
        {
            string magic = "abracadabra";
            Console.WriteLine(magic.Substring(6, 6));

            // I predict this will produce an error, as "dabra" doesn't have 6 characters.
            // It did! OutOfRangeException.
        }
    }
}
