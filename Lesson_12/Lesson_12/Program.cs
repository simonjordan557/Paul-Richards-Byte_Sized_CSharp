using System;

namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            Console.WriteLine(x);

            x = false;
            Console.WriteLine(x);

            bool areSame = 1 == 2;
            Console.WriteLine(areSame);

            // Question: Can '==' operator compare two values of different types? 
            // I predict not, due to strong typing of C#. a float of 10 is not the same as an int of 10.

            float f = 10.0f;
            int i = 10;

            bool b = f == i;
            Console.WriteLine(b);

            // I was wrong, these evaluated true!

            // But what about the results of int / non-int divisions? These would result in different answers, so should evaluate false.

            int j = 3;
            bool k = (i / j) == (f / j);
            Console.WriteLine(k);

            // It did evaluate false, as expected.

            // Some comparisons would be nonsensical, ie bool to int would surely return an error?

            // bool c = b == i;

            // It does flag an error, as expected.

            // I would expect the string "10" and the int 10 to give an error.

            // bool d = i == "10";

            // It gave the same error.

            // I would expect the bool true and the string "true" to return the same error;

            // bool e = true == "true";

            // It did.

            Console.ReadKey();

        }
    }
}
