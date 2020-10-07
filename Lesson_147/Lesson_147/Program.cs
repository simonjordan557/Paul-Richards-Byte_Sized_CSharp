using System;
using System.Text;


namespace Lesson_147
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 12345.678M;
            DateTime dateOfBirth = new DateTime(1973, 3, 23);

            Console.WriteLine(balance.ToString("0.00")); // 2 decimal places

            Console.WriteLine(dateOfBirth.ToString("dd/MM/yyyy")); // no time, only date

            // Question 147: I predict that the output of 0.33 recurring would be limited to 6 decimal places, i.e. "0.000000"

            string s = (1d / 3).ToString("F6");

            // I was correct.
        }
    }
}
