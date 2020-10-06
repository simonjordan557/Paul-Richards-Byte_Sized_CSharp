using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_127
{
    public static class Extensions
    {
        // Note - the answer in the book uses the 'this' keyword in the parameter. I don't think this is necessary, as the method below 
        // doesn't require the use of generics.
        public static string ToUpperOrNull(string str)
        {
            if (str == null)
            {
                return null;
            }

            return str.ToUpper();
        }

    }
}
