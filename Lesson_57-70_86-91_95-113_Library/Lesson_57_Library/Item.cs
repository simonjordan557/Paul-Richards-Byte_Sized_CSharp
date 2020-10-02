using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    // Question 108: Example of polymorphism could be the various different ToString methods in different children of PersonBase.
    public abstract class Item
    {
        public string ReferenceNumber { get; set; }

        public abstract int LoanLimitDays { get; }

        public abstract bool MatchesSearchString(string searchString);
    }
}
