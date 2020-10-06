using System;

namespace Lesson_114_124_Bag
{
    class Program
    {
        static void Main(string[] args)
        {
            Bag<string> bag = new Bag<string>();

            bag.Add("the");
            bag.Add("cat");
            bag.Add("sat");
            bag.Add("on");
            bag.Add("the");
            bag.Add("mat");

            // Question 115: bag.Add(12.5); won't work, as this instance of Bag is set up to take strings as keys.

            Bag<int> bag2 = new Bag<int>();

            for (int i = 0; i <= 24; i += 2)
            {
                bag2.Add(i);
            }

            for (int i = 0; i <= 24; i += 3)
            {
                bag2.Add(i);
            }

            for (int i = 0; i <= 24; i++)
            {
                Console.WriteLine(i + ": " + bag2[i]);

                // Question 116: I expect integers 0, 6, 12, 18, 24 will have 2 instances in the bag2.
                // I predicted correctly.
            }
            
           
        }
    }
}
