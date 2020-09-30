using System;

namespace Lesson_82
{
    class Program
    {

        // It is not possible to access a local variable outside it's scope:
        static void Main(string[] args)
        {
            int localInt = 7;
        }

        public static void AccessCheck()
        {
            localInt = 6;
            Main.localInt = 6;
        }
    }
}
