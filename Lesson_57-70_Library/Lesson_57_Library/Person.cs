using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    public class Person
    {
        
        public Address HomeAddress { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Question 66 - Change the constructors to create a HomeAddress instance on instantiation of a person.
        // This was correct. The book also suggests checking a property is not null before accessing it. This could be done in the 'set' accessor?
        

        // Question 62 - A constructor can't return void, as it implicitly returns the object it's creating.
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + "\nD.O.B: " + DateOfBirth + "\nAddress:\n" + HomeAddress.ToString();
        }

        public int Age()
        {
            // This code as written in the book is not accurate if the person has not yet had their birthday this year.
            // return DateTime.Now.Year - DateOfBirth.Year;

            TimeSpan accurateAge = DateTime.Now - DateOfBirth;
            return (int)accurateAge.TotalDays / 365;
        }

        public bool IsAdult()
        {
            return Age() >= 18;
        }

        
    }
}
