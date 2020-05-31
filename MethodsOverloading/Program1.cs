using System;
using System.Collections.Generic;

namespace ObjectOrientedCSharp
{
    class Program6
    {

        static void Main6(string[] args)
        {
            UseParams();
            UsePoint();
            
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(new int[]{1,2,3,4}));

        }

        static void UsePoint()
        {
            try{
                var point = new Point(10,20);
                point.Move(null);
                Console.WriteLine("at {0} and {1}", point.X, point.Y);

                point.Move(400,600);
                Console.WriteLine("at {0} and {1}", point.X, point.Y);
            } catch(Exception) {
                Console.WriteLine("An unexpected error occured.");
            };
        }
    }
}
