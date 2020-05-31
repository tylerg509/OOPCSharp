using System;

namespace ObjectOrientedCSharp
{
    public class Vehicle
    {
        // public Vehicle()
        // {
        //     Console.WriteLine("Vehicle initializing");
        // }
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle initializing: {0}", registrationNumber);


        }
    }
}
