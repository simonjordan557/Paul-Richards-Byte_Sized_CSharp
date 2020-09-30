using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    class Library
    {
        private readonly string readonlystring;
        private readonly List<Book> books;
        private List<Borrower> borrowers;

        public Library()
        {

            readonlystring = "Hello";
            books = new List<Book>();
           // borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Added " + book.Title);
            int index = books.IndexOf(book);
            Console.WriteLine("Confirming title as " + books[index].Title);
            books[index].Title = "A new title";
            Console.WriteLine("New title is: " + books[index].Title);

            // Can change entries within the list, but not change variable to a new list.
            //readonlystring = "goodbye"; // returns an error
        }

        public Book FindBook(string isbn)
        {
            foreach (Book book in books)
            {
                if (book.ISBN == isbn)
                {
                    return book;
                }
            }

            return null;
        }
    }
}
