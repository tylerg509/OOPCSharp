using System;

namespace ObjectOrientedCSharp
{
    public class PersonNonStatic
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public PersonNonStatic Parse(string str)
        {
            var person = new PersonNonStatic();
            person.Name = str;
            return person;
        }
    }
    class Program2
    {
        static void Main2(string[] args)
        {
            // Note we have to create a new person
            var person = new PersonNonStatic();
            var p = person.Parse("John");
            p.Introduce("Tyler");
        }
    }
}
