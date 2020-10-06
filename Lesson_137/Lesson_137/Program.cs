using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_137
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            string[] arr = { "black", "blue", "green", "grey", "orange", "purple", "red", "white", "yellow" };

            foreach (string s in arr.OrderBy(str => str.Last()).ThenByDescending(str => str.Length))
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        // Question 137

        /*
         *  public IEnumerable<Item> ReturnSearchStringMatches(string str)
         *  {
                return items.Where(i => i.MatchesSearchString(str)).OrderBy(i => i.ReferenceNumber))
                
                    YAAAAASSSSS I got it right. 
         * 
         * 
         * 
         * 
         */
    }
}
