using System;
using System.Linq;

namespace Lesson_178
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static double Median(params double[] values)
        {
            return (values.Length == 0 || values == null) ? double.NaN : values.OrderBy(d => d).Skip((values.Length - 1) / 2).Take(2 - values.Length % 2).Average();
            
        }
    }
}
