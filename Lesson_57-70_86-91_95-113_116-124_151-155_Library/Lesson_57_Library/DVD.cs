using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    class DVD : Item
    {
        public string Title { get; set; }

        public int RunningTimeMinutes { get; set; }

        public override int LoanLimitDays
        {
            get
            {
                return 14;
            }
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
            {
                return false;
            }

            DVD dvd = obj as DVD;

            if (dvd == null)
            {
                return false;
            }

            else
            {
                return (dvd.RunningTimeMinutes == this.RunningTimeMinutes && dvd.Title == this.Title);
            }
        }

        public override bool MatchesSearchString(string searchString)
        {
            return (Title == searchString || ReferenceNumber == searchString);
        }

    }
}
