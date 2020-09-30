using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
   public class TestData
    {
        static TestData()
        {
            TestPerson = new Person("Edward", "Hyde", new DateTime(1990, 1, 1));
        }

        public static Person TestPerson;
    }
}
