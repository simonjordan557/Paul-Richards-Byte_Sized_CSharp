using System;
using System.Linq;
using System.Collections.Generic;

namespace Lesson_141
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 23, 3, 73 };

            Array.ForEach(intArray, bloople => Console.WriteLine(bloople));

            // Question 141:

            List<int[]> arrayList = new List<int[]>();
            int[] intArray2 = { 43, 6, 8 };
            arrayList.Add(intArray);
            arrayList.Add(intArray2);

            Action<int[]> action = arr =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i]++;
                    Console.WriteLine(arr[i]);
                }
            };

            arrayList.ForEach(arr => action(arr));
        }
    }
}
