using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_160
{
    class Test
    {
        // Question 160 - changing the values of a struct in another method is bad, because the struct is a value type, so the changes won't persist 
        // outside of that method. 
        public struct SearchParameters
        {
            public string SearchString { get; }

            public int ResultLimit { get; }

            public SearchParameters(string searchString, int resultLimit)
            {
                SearchString = searchString;
                ResultLimit = resultLimit;
            }

        }
    }
}
