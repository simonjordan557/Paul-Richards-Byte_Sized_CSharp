using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_136
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[] { 2, -4, -2, 6, -5, 3, 9 };

            double sumOfPositives = arr.Where(d => d >= 0).Sum();

            Console.WriteLine(sumOfPositives);

            Console.ReadLine();
        }

        /* Question 136:
         * 
         * public Book FindBook(string isbn)
         * {
               return items.OfType<Book>().Where(b => b.ISBN == isbn).FirstOrDefault(); 
         * 
         * YEEAAAHHHH I got it right!
         * 
         * 
         */
    }
}
