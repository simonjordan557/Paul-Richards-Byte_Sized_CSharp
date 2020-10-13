using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_166
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string a, string b, int c)
        {
            FirstName = a;
            LastName = b;
            Age = c;
        }

        public (string, string, int) Deconstruct(Person p)
        {
            return (FirstName, LastName, Age);
        }
    }
}
