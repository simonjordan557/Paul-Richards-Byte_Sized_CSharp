using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    public class Person : PersonBase
    {
        /// <summary>
        /// The age at which a person is considered an adult.
        /// </summary>
        public const int AgeOfMajority = 18;
        public Address HomeAddress { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Question 66 - Change the constructors to create a HomeAddress instance on instantiation of a person.
        // This was correct. The book also suggests checking a property is not null before accessing it. This could be done in the 'set' accessor?
        

        // Question 62 - A constructor can't return void, as it implicitly returns the object it's creating.
        public Person(string firstName, string lastName) : base(firstName, lastName)
        {
            
            
            HomeAddress = new Address();
        }

        public Person()
        {
            /*Console.WriteLine("Enter your first name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter your birthdate (day 1 - 31)");
            int birthDate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birthdate (month 1 - 12)");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your birthdate (year xxxx)");
            int birthYear = int.Parse(Console.ReadLine());
            DateOfBirth = new DateTime(birthYear, birthMonth, birthDate);
            HomeAddress = new Address();*/
        }

        public override string ToString()
        {
            // Question 99: Duplication is undesirable because you could alter code in one location but not another, causing potentially
            // hard-to-find errors. Less duplication means a single change can correct all parts of code that reference it.
            return base.ToString() + "\nD.O.B: " + DateOfBirth + "\nAddress:\n" + HomeAddress;
        }

        public int Age()
        {
            // This code as written in the book is not accurate if the person has not yet had their birthday this year.
            // return DateTime.Now.Year - DateOfBirth.Year;

            TimeSpan accurateAge = DateTime.Now - DateOfBirth;
            return (int)accurateAge.TotalDays / 365;
        }

        public bool IsAdult() => Age() >= AgeOfMajority;
        

        
    }
}
