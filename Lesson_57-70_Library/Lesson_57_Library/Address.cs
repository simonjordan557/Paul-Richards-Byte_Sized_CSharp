using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_57_Library
{
   public class Address
    {
        public string HouseNumberName { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }

        public override string ToString()
        {
            return HouseNumberName + ", " + Street + ",\n" + Town + ",\n" + Region + ",\n" + Country + ",\n" + PostCode;
        }
    }
}
