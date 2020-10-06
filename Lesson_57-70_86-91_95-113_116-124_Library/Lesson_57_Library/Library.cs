using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lesson_57_Library
{
    class Library
    {
        // Question 102: Or could have seperate list for each subclass of Item.
        private readonly List<Item> items;
        public List<Borrower> borrowers { get; }

        // Question 95:  If the List<string> books was changed to a Dictionary<string>, all references to it would need to be changed. In this case,
        // 'books' is accessed via the constructor or a public method so I don't need to change anything directly except tweaking statements
        // in the AddBook method.

        // Question 96: The public property 'Count' accesses the backing instance field 'books'.
        // Code to search a list and return a result, I'd do it as a method, as presumably it'd have a paramenter to search for, and a result to return.
        // 'get' doesn't take a parameter, just returns a result. 'set' takes a parameter but returns void. As the answer in the book states, searching a list
        // can take a long time.
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
       

        public Library()
        {

            items = new List<Item>();
            borrowers = new List<Borrower>();
           
        }

        public void AddItem(Item item)
        {
            items.Add(item);
           
            

            // Can change entries within the list, but not change variable to a new list.
            //readonlystring = "goodbye"; // returns an error
        }

        public Book FindBook(string isbn)
        {
            foreach (Item item in items)
            {

                // Question 103: != null check is needed in case the item is not a book, we don't want to check the nonexistant 'book.ISBN'.

               
                //Book book = item as Book;

                // Question 104: This method is longwinded and takes extra steps. 'As' keyword checks and casts into Book at the same time.
                // But why not use 'foreach (Book book in items) to automatically only evaluate the books? This all seems unnecessary.

                if (item is Book book && book != null && book.ISBN == isbn)
                {
                  //  Book book = (Book)item;
                   // if (book.ReferenceNumber == isbn)
                  //  {
                        return book;
                   // }
                }
            }

            return null;
        }
    }
}
// Question 105: I think the given code checks an object to see if it implements the IConvertible interface (presumably this is something that is a number)
// and then returns the object (i.e. an int) as a double if true, and as Not A Number if not.

// Question 106: I think properties can't take parameters, because they are reacting to a predefined 'set' call which is by definition passed a value, this value
// is accessed by the 'value' keyword and is therefore not required to be a parameter. and the 'get' call is a predefined method that simply returns a value.
// Anything more complex than this would require a method.

// Question 111: Using 'override' in the method header in a subclass is not enough on its own - the equivalent method in the base class
// must be marked as 'virtual' or 'abstract'.

// Question 112: An interface is by definition completely abstract. So I think it could declare fields but not initialise them.
// This was wrong - fields cannot be abstract. The properites which set them can be.

// Question 113: Trying to inherit from a sealed class should result in an error.
// Correct - it does.

// Question 124: Not assigning anything to the 'out' variable in a method I guess would result in an error? i.e. not all code paths return a value?
// I was correct - a similar error.
