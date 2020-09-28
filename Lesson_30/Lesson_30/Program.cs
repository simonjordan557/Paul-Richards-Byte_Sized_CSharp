using System;

namespace Lesson_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daysInMonth = new int[12];
            daysInMonth[0] = 31;
            daysInMonth[1] = 28;
            daysInMonth[2] = 31;
            daysInMonth[3] = 30;
            daysInMonth[4] = 31;
            daysInMonth[5] = 30;
            daysInMonth[6] = 31;
            daysInMonth[7] = 31;
            daysInMonth[8] = 30;
            daysInMonth[9] = 31;
            daysInMonth[10] = 30;
            daysInMonth[11] = 31;

            int januaryLength = daysInMonth[0];
            int decemberLength = daysInMonth[11];
        }
    }
}
