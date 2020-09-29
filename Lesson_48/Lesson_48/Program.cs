using System;

namespace Lesson_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AskYesOrNo());
        }

        
           public static bool AskYesOrNo()
        {
            string input = "";
            while (input != "yes" && input != "no")
            {
                Console.WriteLine("Enter yes or no");
                input = Console.ReadLine();
            }

            return input == "yes";
        }
    }
}
