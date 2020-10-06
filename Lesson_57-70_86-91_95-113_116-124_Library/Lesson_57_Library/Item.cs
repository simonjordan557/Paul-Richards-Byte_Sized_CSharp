using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    // Question 108: Example of polymorphism could be the various different ToString methods in different children of PersonBase.
    public abstract class Item
    {
        //private readonly string referenceNumber;
        public string ReferenceNumber { get; }

        // Question 122: Providing a constructor that takes in a string invalidates the creation of a DVD item supplying no argument as a parameter.
        // So I either have to supply an argument in the Main() method when instantiating a DVD, supply a constructor in the DVD class which calls back
        // to the base constructor in Item, or explicitly add a default empty constructor.

        // Question 123: 'this.referencenumber' isn't needed because an invisible backing field is created with the ReferenceNumber autoproperty, which is set
        // automatically in the constructor. And as the book answer points out, the two variables can't be confused since they use R and r respectively.
        // To be fair, you'd never use the first implementation where the name of the parameter is the same as a field, it's sloppy and prone to error.


        public abstract int LoanLimitDays { get; }
        protected Item(string referenceNumber)
        {
            // this.referenceNumber = referenceNumber
            ReferenceNumber = referenceNumber;
        }

        protected Item()
        {

        }
        public abstract bool MatchesSearchString(string searchString);

        public override bool Equals(object obj)
        {
            Item item = obj as Item;

            if (item == null)
            {
                return false;
            }

            return (item.ReferenceNumber == this.ReferenceNumber);
        }

        public override int GetHashCode()
        {
            if (ReferenceNumber == null)
            {
                return base.GetHashCode();
            }

            return ReferenceNumber.GetHashCode();
        }
    }
}
