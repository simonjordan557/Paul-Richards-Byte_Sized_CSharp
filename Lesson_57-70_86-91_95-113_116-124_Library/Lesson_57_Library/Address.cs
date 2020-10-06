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

        public Address()
        {
            // Console.WriteLine("Enter your house number or name:");
            // HouseNumberName = Console.ReadLine();
            // Console.WriteLine("Enter your street name:");
            // Street = Console.ReadLine();
            // Console.WriteLine("Enter your town:");
            // Town = Console.ReadLine();
            // Console.WriteLine("Enter your county:");
            // Region = Console.ReadLine();
            // Console.WriteLine("Enter your country:");
            // Country = Console.ReadLine();
            // Console.WriteLine("Enter your postcode:");
            // PostCode = Console.ReadLine();
        }

        public override string ToString()
        {
            return HouseNumberName + ", " + Street + ",\n" + Town + ",\n" + Region + ",\n" + Country + ",\n" + PostCode;
        }

    }
}
