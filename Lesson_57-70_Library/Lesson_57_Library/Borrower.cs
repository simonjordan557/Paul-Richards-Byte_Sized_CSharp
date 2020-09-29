using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    class Borrower : Person
    {
        public string MembershipNumber { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nMembership Number: " + MembershipNumber;
        }
    }

    
        
        
}
