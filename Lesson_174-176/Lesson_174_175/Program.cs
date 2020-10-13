using System;
using System.IO;


namespace Lesson_174_175
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 174: I guess buffers are used because loading a string to memory, writing it, repeatedly, consumes more CPU resources than piling all 
            // strings to memory then writing once? 

            // Question 175: Using the 'using' keyword with an IDisposable automatically implements the Dispose() method once the code block exits - 
            // so in this case there's no need to call Close() because it's done implicitly by the Dispose() method.

            const string fileName = @"L:\Backup 19.1.18\Gamedev\Visual Studio 2019\Paul_Richards_C#_Programming_In_Byte-Sized_Lessons\Lesson_174_175\test.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        writer.WriteLine(i);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            using (StreamReader reader = new StreamReader(fileName))
            {
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
            }
            

        }
    }
}
