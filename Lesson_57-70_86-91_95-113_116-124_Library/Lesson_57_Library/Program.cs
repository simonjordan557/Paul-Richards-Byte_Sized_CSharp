using System;
using System.Net.Http.Headers;

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
            //Person person = new Person("Simon", "Jordan", new DateTime(1981, 10, 10));

            // Lesson 100 question: Trying to create an instance of Item should fail, since it is an abstract class - a template of templates.
            // It's not s blueprint for the structure of an object - it's a blueprint for the structure of a class. A class can inherit it, but an object cannot.

            // Item item = new Item(); Fails as predicted.

            // Question 101: Person person = new PersonBase("John", "Smith"); won't work because Person is a child of PersonBase. 
            // Substitutability only works for child classes of the instantiated object. i.e. an array of bankAccounts can contain childAccounts and Adultaccounts,
            // but an array of Adultaccounts can't contain bankAccounts.


            // person2 created using the default constructor, so doesn't initialise any properties. They remain null.
            // Person person2 = new Person();
            //  Console.WriteLine($"Person 2: {person2}");

            // PrintName(person2);

            // Question 64

            //Person personJohn = new Person();
            //personJohn.FirstName = "John";


            //PrintName(person);
            //int age = person.Age();
            //Console.WriteLine("The age is " + age + " years old.");
            //bool over18 = person.IsAdult();
            //if (over18)
            //{
            //    Console.WriteLine(person.FirstName + " is an adult.");
            //}

            //else
            //{
            //    Console.WriteLine(person.FirstName + " is NOT an adult.");
            //}

            // Question 66

            //if (person.HomeAddress == null)
            //{
            //    person.HomeAddress = new Address();
            //}

            //person.HomeAddress.PostCode = "SK15 3BR";
            //string testString = (person.HomeAddress.PostCode);
            //Console.WriteLine(testString);

            // Question 67: still getting an exception because stringArr is unassigned? And it turns out this is the example given in the book.
            // Maybe better to check for null first.

            //string[] stringArr;
            //string str = stringArr?[0];
            //Console.WriteLine(str);

            // Question 68 and 70

            //Borrower borrower = new Borrower();
            //borrower.FirstName = "John";
            //borrower.LastName = "Smith";
            //borrower.MembershipNumber = "ABC123";

            // This uses the overridden ToString in Borrower
            // Console.WriteLine(borrower);

            // Question 70

            //Person lastPerson = new Person("Joe", "Bloggs", new DateTime(1950, 12, 12));
            //lastPerson.HomeAddress = new Address();
            //lastPerson.HomeAddress.HouseNumberName = "1";
            //lastPerson.HomeAddress.Street = "Main Road";
            //lastPerson.HomeAddress.Town = "Nicetown";
            //lastPerson.HomeAddress.Region = "Countyshire";
            //lastPerson.HomeAddress.Country = "England";
            //lastPerson.HomeAddress.PostCode = "AA11 1AA";

            //Console.WriteLine(lastPerson);

            // Question 86: If the 'books' list isn't initialised in the Library constructor, using the Addbook method should fail
            // with a 'reference not set to an instance of an object' error, or something similar.

            // Question 97: Changing 'Author' from a string to a Person led to an error, since I tried to assign a string to a Person when entering
            // the name of the author. I had to create a new Person instance and assign it to 'Author' in the constructor of Book, 
            // then I could assign values to Author.FirstName and Author.LastName directly. This only works with the constructors left empty. 

            //  Book LOTR = new Book("J R R", "Tolkien", "The Lord Of The Rings", "001");
            // LOTR.Author.FirstName = "J R R";
            // LOTR.Author.LastName = "Tolkien";
            // LOTR.ISBN = "001";
            // LOTR.Title = "The Lord Of The Rings";





            // Library library = new Library();
            //library.AddItem(LOTR);

            //  DVD heat = new DVD();
            //  heat.Title = "Heat";
            //  library.AddItem(heat);

            //  Book found = library.FindBook(LOTR.ISBN);
            //  Console.WriteLine("\nSuccessfully found the book with ISBN " + found.ISBN + " and title " + found.Title + ".");

            // Outcome was as expected.

            // Question 88:

            // Person.AgeOfMajority = 17;

            // Question 89:
            //  Console.WriteLine("TestPerson's name is " + TestData.TestPerson.FirstName);
            //  Person testGuy = TestData.TestPerson;
            //  Console.WriteLine("testGuy's name is " + testGuy.FirstName);


            // This correctly assigns the data to the testguy. Since the TestPerson is a static member of the class, it could be accessed without the class 
            // constructor ever being used, which would result in a null reference error, since the TestPerson is declared but not initialised. 
            // So the static constructor initialises static variables at runtime, ensuring they are ready as soon as needed. 
            // So you could declare static int 'AgeOfMajority'; and a static constructor to set AgeOfMajority = 18;

            // Question 90: 'library.books' is inaccessible due to its protection level - as it is private and readonly. But can still be accessed within its 
            // own class, and that method is public so acts as a gatekeeper between an unauthorised class (this one) and a private field. 
            // And despite being readonly, a method in its own class can add entries to, and alter entries in the list. But it can't set 'books' equal to a different list.
            // readonly and read only are two different things. To be read only, you'd use accessors such as leaving out a 'set' in the property, I think.

            //Console.WriteLine(library.books[0]);

            Bag<DVD> bag = new Bag<DVD>();

            DVD dvd1 = new DVD();
            dvd1.Title = "The Jungle Book";
            dvd1.ReferenceNumber = "DVD001";

            DVD dvd2 = new DVD();
            dvd2.Title = "The Jungle Book";
            dvd2.ReferenceNumber = "DVD001";

            bag.Add(dvd1);
            bag.Add(dvd1);
            Console.WriteLine(bag[dvd1]);

            // Question 117: Adding two instances of 'dvd1' should result in one entry in the 'bag' dictionary, holding a value of 2.
            // Worked as predicted.

            // Question 118: an object calling Equals on itself should return true.

            bool test = dvd1.Equals(dvd1);
            Console.WriteLine($"Equals test: {test}.");

            // It returned true.

            bool test2 = dvd1.Equals(dvd2);
            Console.WriteLine($"dvd1 vs dvd2 Equals test: {test2}.");

            // It evaluates dvd1 and dvd2 as unEqual (false), because they are two distinct instances, despite having the exact same state.

            int dvd1Hash = dvd1.GetHashCode();
            int dvd2Hash = dvd2.GetHashCode();

            Console.WriteLine($"dvd1 HashCode is: {dvd1Hash}");
            Console.WriteLine($"dvd2 HashCode is: {dvd2Hash}");

            // These are different Hash Codes. Odd, I thought they would be the same, since the objects share the same state. How to make the system see
            // they are the same, just with different identifiers, so they can be properly classified in the Dictionary?

            // Apparently the hashcode is based on memory location, so as the different instances are stored in different memory locations, the hashcodes
            // are unique. 

            // By overriding the GetHashCode function, It's possible to base the hashcode on a property of the item, ie the string ReferenceNumber,
            // so the same string in two items generates the same hashcode. So maybe if the Equals() method is overridden to test the hashcode
            // using the overridden GetHashCode() method, the Dictionary would automatically use that for the equality test?


            // Question 121: GetHashCode() should return the same value for the lifetime of an object, because it could be stored in one section of a hashtable,
            // then only searched for in a different section after the hashcode changed, and would never be found. Use a readonly field to control hashcode.


            Console.ReadKey();
          }
        public static void PrintName(Person p)
        {
            Console.WriteLine("The full name is " + p.FirstName + " " + p.LastName + ".");
        }
    }
}
