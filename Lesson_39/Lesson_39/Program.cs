using System;

namespace Lesson_39
{
    class Program
    {
        static void Main(string[] args)
        {
            // Failure of the Parse() method leads to an exception being automatically thrown, which then led to execution of code in the catch block.
            // Catch block is used for recovery.

            // Question 39: TryParse returns a bool to indicate whether parse will work, while also updating the double via the 'out' keyword.
            // Essentially this method has 2 returns, the double and the bool. So even if it doesn't work, no exception is thrown, the bool is
            // flagged false, code continues to execute as normal. Could then follow with 'if (bool is false)...' to deal with failstate without
            // using exceptions.
            
                string s = "seven point five";
                double x;
                bool didItWork = double.TryParse(s, out x);
                Console.WriteLine(x);
                Finish();
            

            
        }

        public static void Finish()
        {
            Console.WriteLine("Made it to the Finish() method.");
            Console.ReadKey();
        }
    }
}
