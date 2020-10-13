using System;
using System.Windows.Markup;

namespace Lesson_168
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 168: This code adds all indices between a certain start and endpoint, or defaults to first / last index if those parameters are null.
            

            // This code will return true as the int '2' and the int? '2' are implicitly converted and compatible.

            int? test = 2;
            Console.WriteLine(test == 2);
            Console.ReadLine();

            // Question 169: I think result1 will return 1, since it adds an int? null to an int 1, and they're implicitly converted.
            // I think result2 will stay null because it doesn't have a property Value, since HasValue is false. 
            // You'd have to precede the line with the condition 'if (nextTest.HasValue)'

            // result1 actually returns null, I guess anything + null = null. But it does compile and run. Should check null or zero first.
            // As expected with result2, I got the error message 'Nullable object must have a value.'

            int? nextTest = null;
            var result1 = nextTest + 1;
            Console.WriteLine(result1);
            var result2 = nextTest.Value + 1;
            Console.WriteLine(result2);
            Console.ReadLine();

            double[] array = { 0.3, 4, 4.8, 3.5, 4.3, 5.6, 3.8, 2.5, 0.4, 1.7 };
            double result3 = Sum(array, null, 5);


        }
        // This handles null values well, but you still need to pass in 'null' in the argument when calling.

        // You could use default parameters in the method header: public static double Sum(double[] values, int? start = null, int? end = null)
        // This lets the method compile even if not supplied with all its parameters, since null is then assigned automatically to missing parameters.
        // It's like havin g multiple method overloads for every input scenario, but way quicker to read / write.

        public static double Sum(double[] values, int? start, int? end)
        {
            //int realStart = start ?? 0;


            /*  int realStart;
              if (start.HasValue)
              {
                  realStart = start.Value;
              }

              else
              {
                  realStart = 0;
              }

              */

            int realStart = start.HasValue ? start.Value : 0;


            int realEnd = end ?? values.Length - 1;
            double total = 0;
            for (int i = realStart; i <= realEnd; i++)
            {
                total += values[i];
            }

            return total;
        }
    }
}
