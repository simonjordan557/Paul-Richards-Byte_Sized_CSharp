using System;

namespace Lesson_57_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson 57 Question: Why decomposition?
            // Breaking complex problems into simpler and simpler sub-problems makes them human-manageable.
            // It allows for structure and thread of execution.
            // It leads to components, which could be classes or methods.


            // Lesson 60 Question

            // person created using overloaded contructor, intialising its properties.
            Person person = new Person("Simon", "Jordan", new DateTime(1981, 10, 10));
            

            // person2 created using the default constructor, so doesn't initialise any properties. They remain null.
            Person person2 = new Person();
            PrintName(person2);

            // Question 64

            Person personJohn = new Person();
            personJohn.FirstName = "John";

            
            PrintName(person);
            int age = person.Age();
            Console.WriteLine("The age is " + age + " years old.");
            bool over18 = person.IsAdult();
            if (over18)
            {
                Console.WriteLine(person.FirstName + " is an adult.");
            }

            else
            {
                Console.WriteLine(person.FirstName + " is NOT an adult.");
            }

            // Question 66

            if (person.HomeAddress == null)
            {
                person.HomeAddress = new Address();
            }

            person.HomeAddress.PostCode = "SK15 3BR";
            string testString = (person.HomeAddress.PostCode);
            Console.WriteLine(testString);

            // Question 67: still getting an exception because stringArr is unassigned? And it turns out this is the example given in the book.
            // Maybe better to check for null first.

            //string[] stringArr;
            //string str = stringArr?[0];
            //Console.WriteLine(str);

            // Question 68 and 70

            Borrower borrower = new Borrower();
            borrower.FirstName = "John";
            borrower.LastName = "Smith";
            borrower.MembershipNumber = "ABC123";

            // This uses the overridden ToString in Borrower
           // Console.WriteLine(borrower);

            // Question 70

            Person lastPerson = new Person("Joe", "Bloggs", new DateTime(1950, 12, 12));
            lastPerson.HomeAddress = new Address();
            lastPerson.HomeAddress.HouseNumberName = "1";
            lastPerson.HomeAddress.Street = "Main Road";
            lastPerson.HomeAddress.Town = "Nicetown";
            lastPerson.HomeAddress.Region = "Countyshire";
            lastPerson.HomeAddress.Country = "England";
            lastPerson.HomeAddress.PostCode = "AA11 1AA";

            Console.WriteLine(lastPerson);
         
            Console.ReadKey();

        }

        public static void PrintName(Person p)
        {
            Console.WriteLine("The full name is " + p.FirstName + " " + p.LastName + ".");
        }
    }
}
