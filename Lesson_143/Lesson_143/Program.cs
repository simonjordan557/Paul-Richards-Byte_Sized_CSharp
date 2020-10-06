using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson_143
{
    class Program
    {

        // Weirdly, I found Linq to be quicker than traditional code, but I do have two nested for loops, which may be why.
        // When I got rid of nested loops and used a while loop inside the for loop which only ran until the first composite divisor was found,
        // it turned out Linq was slower than optimised regular code.
        // Regular code is more long-winded but easier to read and debug. Linq is more concise and easier to read for an expert, and very powerful.
        // If Linq got heavily bogged down then you should go with what is quicker.
        // For a more lightweight function, maybe Linq is faster.
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            GetPrimes(10000);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            GetPrimes2(10000);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            GetPrimes3(10000);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        public static List<int> GetPrimes(int max)
        {
            return Enumerable.Range(1, max).Where(i => i >= 1 && !Enumerable.Range(2, i-1).All(j => i % j > 0)).ToList();
        }

        public static List<int> GetPrimes2(int max)
        {
            bool isPrime;
            List<int> primes = new List<int>();
            primes.Add(1);
            
            for (int i = 3; i <= max; i++)
            {
                isPrime = true;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static List<int> GetPrimes3(int max)
        {
            List<int> primes = new List<int>();
            int j;
            bool isPrime;

            if (max >= 1)
            { 
                primes.Add(1); 
            }

            if (max >= 2)
            {
                primes.Add(2);
            }

            for (int i = 1; i <= max; i++)
            {
                j = 2;
                isPrime = i >= 1;
                while (j < i && isPrime)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                    j++;
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}
