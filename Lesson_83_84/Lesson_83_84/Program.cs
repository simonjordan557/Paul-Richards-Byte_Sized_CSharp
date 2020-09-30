using System;
using System.Collections.Generic;

namespace Lesson_83_84
{
    class Program
    {
        static void Main(string[] args)
        {
            // Visual Studio recognises that this should be a string.
            var name = "John Smith";

            // Question 84: What if the var is a complicated type?

            var patientData = new Dictionary<string, Dictionary<int, List<string>>>();

            // The compiler is not confused, even if the programmer is.
        }
    }
}
