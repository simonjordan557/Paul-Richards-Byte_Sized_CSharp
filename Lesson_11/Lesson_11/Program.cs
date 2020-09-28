using System;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2000000000;
            int y = 2000000000;

            long z = x + 2100000000l;

            Console.WriteLine(z);

            // Specified l for long, so int + long widened to a long and assigned correctly to 'z'.

            long a = (long)x + y;

            Console.WriteLine(a);

            // Can't widen variables, only literals. So had to cast into a long, long + int = long, so correct assignment to 'a'.

            // Question: Can you always assign a float to a double?
            // I predict yes, because that is widening so doesn't require an explicit cast.

            float f = 600.5f;
            double d = f;

            Console.WriteLine(d);

            Console.ReadKey();

            // It worked.
               

            
        }
    }
}
