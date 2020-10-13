using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lesson_171_172
{
    class Program
    {
        // Question 171: The default value for a string is null.

        static void Main(string[] args)
        {
            const string fileName = @"L:\Backup 19.1.18\Gamedev\Visual Studio 2019\Paul_Richards_C#_Programming_In_Byte-Sized_Lessons\Lesson_171_172\test.txt";
            IEnumerable<string> data = Enumerable.Range(1, 100).Select(i => i.ToString());
            File.WriteAllLines(fileName, data);

            // Question 172: This doesn't work, I think file is a static class? some static methods within File would return a Filestream, like File.Open().
            // File f = new File();
            
        }
    }
}
