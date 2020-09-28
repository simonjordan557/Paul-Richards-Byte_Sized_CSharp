using System;

namespace Lesson_27
{
    class Program
    {/// <summary>
    ///  Typing 3 slashes '///' above a method or class header generates this xml snippet. type comments between the appropriate tags to follow a default format for documentation.
    /// </summary>
    /// <param name="args">This is to allow you to pass in string arguments to start the main method, ie from a config file.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // This is an inline comment
            string message = "Seeya!";
            Finish(message);
        }
        /// <summary>
        /// This method takes in a string to customise the program exit text.
        /// </summary>
        /// <param name="s">The custom message to display to the user.</param>
        public static void Finish(string s)
        {
            Console.WriteLine(s); // Display the custom text
            Console.WriteLine("Press any key to exit."); // Display the standard text
            Console.ReadKey();
        }

        /*
         * This is a block
         * comment. You can
         * type loads of
         * stuff over
         * multiple lines.
         */

        // Question: Why bother with comments?

        /*
         * Comments remind you what your code is supposed to do, 
         * or what you THINK it's supposed to do. So when it 
         * doesn't work as expected it's easier to spot
         * the part that's going wrong.
         * 
         * They help divide your code up nicely, and help you
         * follow the flow of execution.
         * 
         * It's also helpful when revisiting old code where
         * you've forgotten the leaps of logic you took to make
         * the code work. It can make sense of lots of obscure 
         * algebra, recursion etc.
         * 
         * They also guide others who may work on your code after 
         * you've finished with it.
         */
    }
}
