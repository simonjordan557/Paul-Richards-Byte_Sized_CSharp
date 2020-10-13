using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_161
{
    class Test
    {
        public int a;
        public int b;

        public override string ToString()
        {
            return ($"a = {a}, b = {b}.");
        }

        public static bool operator ==(Test t1, Test t2)
            {
            return (t1.a == t2.a && t1.b == t2.b);
            }

        public static bool operator !=(Test t1, Test t2)
        {
            return !(t1.a == t2.a && t1.b == t2.b);
        }
    }
}
