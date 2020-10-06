using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Lesson_129
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19 };

            Console.WriteLine($"Minimum = {primes.Min()}");
            Console.WriteLine($"Maximum = {primes.Max()}");
            Console.WriteLine($"Sum = {primes.Sum()}");
            Console.WriteLine($"Count = {primes.Count()}");
            Console.WriteLine($"Average = {primes.Average()}");

            Console.ReadKey();

            List<string> daysOfWeek = new List<string>() { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };

            Console.WriteLine($"Minimum = {daysOfWeek.Min()}");
            Console.WriteLine($"Maximum = {daysOfWeek.Max()}");
         // Console.WriteLine($"Sum = {daysOfWeek.Sum()}");
            Console.WriteLine($"Count = {daysOfWeek.Count()}");
         // Console.WriteLine($"Average = {daysOfWeek.Average()}");

            Console.WriteLine(daysOfWeek.Max(ghjggg => ghjggg.Length));

            Console.ReadKey();

            // Question 129:

            Console.WriteLine(daysOfWeek.Sum(str => str.Length));

            Console.ReadKey();
            




        }
    }
}
