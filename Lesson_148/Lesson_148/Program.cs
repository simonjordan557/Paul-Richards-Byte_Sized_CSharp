using System;

namespace Lesson_148
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Mr.";
            string firstName = "Simon";
            string lastName = "Jordan";
            DateTime dateOfBirth = new DateTime(1983, 5, 11);
            decimal balance = 365.67M;
            decimal creditLimit = 3000M;

            string summary = string.Format("Account Holder: \"{0} {1} {2}\", Date Of Birth: {3:dd/MM/yyyy}, Balance: £{4:0.00}, Credit Limit: £{5:0.00}.", title, firstName, lastName, dateOfBirth, balance, creditLimit);
            Console.WriteLine(summary);

            // Question 148: It would be possible to repeat the same value, simply by repeating the placeholder.

        }
    }
}
