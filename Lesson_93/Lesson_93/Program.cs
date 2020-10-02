using System;
using System.Collections.Generic;

namespace Lesson_93
{
    class Program
    {
        static void Main(string[] args)
        {
            // I expect the first line will work, since 'Library' is a public class, but the second line will fail,
            // as it is trying to access a private property from another class.

            Library library = new Library();
            library.books = new List<Book>();

            // It behaved as expected. 
        }
    }
}
