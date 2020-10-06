using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
    class Book : Item
    {
        public string ISBN { get; set; }
        public Person Author { get; set; }
        public string Title { get; set; }

        public override int LoanLimitDays
        {
            get
            {
                return 21;
            }
        }

        public Book(string firstName, string lastName, string title, string isbn)
        {
            Title = title;
            ISBN = isbn;
            Author = new Person(firstName, lastName);
            
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
            {
                return false;
            }

            Book book= obj as Book;

            if (book == null)
            {
                return false;
            }

            else
            {
                return (book.ISBN == this.ISBN && book.Title == book.Title && book.Author == this.Author);
            }
        }

        public override bool MatchesSearchString(string searchString)
        {
            return (ISBN == searchString || Title == searchString || Author.FirstName == searchString || Author.LastName == searchString || ReferenceNumber == searchString);
        }
    }
}
