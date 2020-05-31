using System;

namespace ObjectOrientedCSharp
{
    public class PersonStatic
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static PersonStatic Parse(string str)
        {
            var person = new PersonStatic();
            person.Name = str;
            return person;
        }
    }
    class Program3
    {
        static void Main3(string[] args)
        {
            // Note that since we made person parse static we can pass in a param here istead of having to create a new instance of person
            var p = PersonStatic.Parse("John");
            p.Introduce("Tyler");
        }
    }
}
