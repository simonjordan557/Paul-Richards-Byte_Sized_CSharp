using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    class Borrower : Person
    {
        public string MembershipNumber { get; set; }

        // Question 98: It is possible to avoid compliler errors by ensuring there is always a zero-parameter constructor
        // further up the chain to maintain compatability. The more constructors you have, the more potential situations you can
        // cope with without getting an error.
        public Borrower(string firstName, string lastName) : base(firstName, lastName)
        {
            Console.WriteLine("Enter membership number: ");
            MembershipNumber = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + "\nMembership Number: " + MembershipNumber;
        }
    }

    
        
        
}
