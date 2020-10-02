using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
   public class TestData
    {
        static TestData()
        {
            TestPerson = new Person("Edward", "Hyde");
        }

        public static Person TestPerson;
    }
}
