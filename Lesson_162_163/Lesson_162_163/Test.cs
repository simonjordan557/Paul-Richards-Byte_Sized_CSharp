using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_162_163
{
    class Test
    {
        public string name;
        public int age;
        public enum Colours
        {
            blue,
            green,
            red
        }

        Colours favouriteColour;
        
        public Test(string s, int i, Colours c)
        {
            name = s;
            age = i;
            favouriteColour = c;
        }

        public override string ToString()
        {
            return ($"NAME: {name}\nAGE: {age}\nFAVOURITE COLOUR: {favouriteColour}\n");
        }



    }
}
