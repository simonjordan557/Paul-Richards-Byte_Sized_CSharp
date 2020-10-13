using System;
using System.IO;

namespace Lesson_173
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = @"L:\Backup 19.1.18\Gamedev\Visual Studio 2019\Paul_Richards_C#_Programming_In_Byte-Sized_Lessons\Lesson_173\test.txt";
            StreamWriter writer = new StreamWriter(fileName);
            for (int i = 0; i <= 100; i++)
            {
                writer.WriteLine(i);
            }
            writer.Close();

            StreamReader reader = new StreamReader(fileName);
            string line;

            do
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }
            }
            while (line != null);
            reader.Close();

            // Question 173: I think the line != null checks are to avoid an exception when the Console.WriteLine encounters a null when loop reaches the end of the file.

        }
    }
}
