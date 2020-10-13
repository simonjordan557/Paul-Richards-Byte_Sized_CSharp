using System;
using System.Runtime.ExceptionServices;

namespace Lesson_166
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Simon", "Jordan", 27);
            (string, string, int) personValues = person.Deconstruct(person);
            Console.WriteLine($"First name: {personValues.Item1}\nLast name: {personValues.Item2}\nAge: {personValues.Item3}");

            var (first, last, old) = person.Deconstruct(person);
            Console.WriteLine($"First name: {first}\nLast name: {last}\nAge: {old}");

            var (_, _, onlyAge) = person.Deconstruct(person);
            Console.WriteLine($"Only interested in the age: {onlyAge}");
            Console.ReadLine();

            
        }
    }
}
