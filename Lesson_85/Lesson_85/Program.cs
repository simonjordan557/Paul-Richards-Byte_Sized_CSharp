using System;

namespace Lesson_85
{
    class Program
    {
        static void Main(string[] args)
        {

             bool checked = true;
            // Shouldn't work, as 'checked' is a reserved keyword in C#.

             decimal 100cost = 100.00M;
            // Shouldn't work, as identifier shouldn't start with a number.

             double age2 = 10.5;
            // Should work, digit is fine to end an identifier.

            int the age = 18;
            // Shouldn't work, as there is a space in the identifier.

             int the_age = 18;
            // This should work. Underscores are fine.

             string _priority = "high";
            // This should work. I think there is a convention of naming fields with an underscore.

             string question? = "why?";
            // This shouldn't work: '?' is a key symbol (to check for null).

             string theBestQuestion = "why, what and how?";
            // Should be fine, camel-case is accepted format for variables.

             string s = "hello";
            // It should work, but not good practice, as the identifier doesn't tell the reader what the variable is for.

             bool fixed = false;
            // Shouldn't work, as 'fixed' is a reserved keyword in C#.

             // Having removed comments from these declarations / initialisations, my predictions turned out to be correct.
     
             
             
             
        }
    }
}
