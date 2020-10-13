using System;



namespace Lesson_157
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;
            Console.WriteLine($"x before method: {x}");
            Test(ref x);
            Console.WriteLine($"x after method: {x}");
            Console.ReadLine();

            string firstName = "Simon";
            string lastName = "Jordan";
            Console.WriteLine($"{firstName} {lastName}");
            Swap(ref firstName, ref lastName);
            Console.WriteLine($"{firstName} {lastName}");
            Console.ReadLine();

            int a = 1;
            int b = 2;
            Console.WriteLine($"{a} {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"{a} {b}");
            Console.ReadLine();
        }

        public static void Test(ref int i)
        {
            Console.WriteLine($"i at start of method: {i}");
            i++;
            Console.WriteLine($"i at end of method: {i}");
        }

        // Question 157: This method takes two values of any type and swaps them over, passed by reference, so even if they are value types, they still remain
        // swapped outside of the method.
        public static void Swap<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }
    }
}
