using System;

namespace ObjectOrientedCSharp
{
    public class Customer4
    {
        public int Id;
        public string Name;

        public Customer4(){
            Id = 1;
            Name = "Gooseberry";
            Console.WriteLine("{0} Falls {1}", Name, Id);
        }

        public Customer4(string nameOfFalls){
            Id = 1;
            Name = nameOfFalls;
            Console.WriteLine("{0} falls {1}", Name, Id);
        }

        public Customer4(string nameOfFalls, int id){
            Id = id;
            Name = nameOfFalls;
            Console.WriteLine("{0} falls, {1}", Name, Id);
        }

    }
    class Program4
    {
        static void Main4(string[] args)
        {
            Customer4 customer = new Customer4();
            Customer4 customer1 = new Customer4("Red");
            Customer4 customer2 = new Customer4("Body", 2);
        }
    }
}
