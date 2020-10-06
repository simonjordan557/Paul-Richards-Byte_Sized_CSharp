using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lesson_142
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int x = 1;
            int y = 2;
            int z = 3;
            int total = z * y - x;
            Console.WriteLine(total);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            for (int i = 0; i < 1000000000; i++)
            {
                z++;
            }
            Console.WriteLine(total);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            Console.WriteLine(total);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            int a = 65;
            int b = 7634;
            int c = 4;
            int d = 45;
            int e = 35;

            total = a * b / c + d - e;
            Console.WriteLine(total);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            Console.WriteLine(total);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            Console.WriteLine(total);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            Console.WriteLine(total);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            // Question 142: Stopwatch.Restart() will stop the current time interval, reset to zero and immediately start a new interval.
        }
    }
}
