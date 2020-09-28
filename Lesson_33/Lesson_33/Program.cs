using System;

namespace Lesson_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 3, 5];
            
            Console.WriteLine("Length of first dimension: " + arr.GetLength(0));
            Console.WriteLine("Length of second dimension: " + arr.GetLength(1));
            Console.WriteLine("Length of third dimension: " + arr.GetLength(2));

            int numberOfDimensions = arr.Rank;
            int totalElements = arr.GetLength(0);

            for (int i = 1; i < numberOfDimensions; i++)
            {
                totalElements *= arr.GetLength(i);
            }

            Console.WriteLine("Total number of elements: " + totalElements);
            Console.ReadKey();
        }

    }
}
