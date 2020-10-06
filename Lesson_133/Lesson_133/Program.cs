using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Lesson_133
{

    // Question 133: I predict using Distinct() on an array would not alter the array itself, as it returns a new IEnumerable which has the 
    // duplicate entries removed, the original array is unchanged.
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "simon";
            string lastName = "jordan";
            string fullName = firstName + " " + lastName;

            foreach (char c in firstName.Intersect(lastName))
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

            foreach (char c in firstName.Except(lastName))
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

            foreach (char c in firstName.Union(lastName))
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

            foreach (char c in firstName.Concat(lastName))
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();

            foreach (char c in fullName.Distinct())
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
