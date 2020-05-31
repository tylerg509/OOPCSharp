using System;
using System.Collections.Generic;

namespace ObjectOrientedCSharp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer(){
            // If you do not initalize this you would need to initalize the list of orders when you use this class
            // So whenyou have a list of objects in your properies in a class always initalize it!
            Orders = new List<Order>();
            
        }

        // The use of this within the following consturctor will ensure that the order list is initalized like it is
        // in the constructor with no parameters
        public Customer(string nameOfFalls)
            : this() 
        {
            Id = 2;
            Name = nameOfFalls;
            Console.WriteLine("{0} falls {1}", Name, Id);
        }

        // The use of this within the followin constructor will ensure that the order list is initalized
        // and that the name is set as it is in the second constructor
        public Customer(string nameOfFalls, int id)
            : this(nameOfFalls)
        {
            Id = id;
            Console.WriteLine("{0} falls, {1}", Name, Id);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer1 = new Customer("Red");
            Customer customer2 = new Customer("Body", 3);
        }
    }
}
