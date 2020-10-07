using System;
using System.Text;
using System.Diagnostics;

namespace Lesson_146
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            string s1 = "";
            for (int i = 0; i < 100000; i++)
            {
                s1 += "ab";
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Reset();
            sw.Start();

            string s2;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 100000; i++)
            {
                sb.Append("ab");
            }
            s2 = sb.ToString();

            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);

            // Question 146: I don't thing StringBuilder is necessary for this operation, it's not resource-intensive as it's only three strings concatenated. It probably takes
            // more effort to create an instance of StringBuilder. String concatenation and StringBuilder both cope fine with null strings, they treat them as "", so no difference
            // in functionality either.

            StringBuilder sb2 = new StringBuilder();
            string firstName = "Paul";
            string middleName = null;
            string lastName = "Richards";

            string fullName = firstName + middleName + lastName;
            Console.WriteLine(fullName);

            sb2.Append(firstName);
            sb2.Append(middleName);
            sb2.Append(lastName);

            Console.WriteLine(sb2);
            Console.ReadLine();
        }

        
    }
}
