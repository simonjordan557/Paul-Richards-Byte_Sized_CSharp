using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    public class PersonBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonBase(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public PersonBase()
        {

        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
