using System;
using System.Linq;
using System.Collections.Generic;
    

namespace Lesson_140
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            List<int[]> arrayList = new List<int[]> { array1, array2 };

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

        // This was exactly as described in the book's answer!!
    }
}
