using System;

namespace ObjectOrientedCSharp
{
    public class Car : Vehicle 
    {
        // Use of base will take the parameter and pass it to the base class constructor parameter
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car initalizing: {0}", registrationNumber);
        }
    }
}
 