using System;

namespace ObjectOrientedCSharp
{
    public class Circle : Shape 
    {
        public override void Draw()
        {
            //Any code specific to the circle itself
            Console.WriteLine("draw circle");
            //could call the base method
            //base.Draw();
        } 
    }

    public class Rectangle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("draw rectangle");
        } 
    }

    public class Triangle  : Shape{
        public override void Draw(){
            Console.WriteLine("draw triangle");
        }
    }
    public class Shape
    {
        public int Width {get;set;}
        public int Height {get;set;}
        public Position Position {get;set;}

        //Virtual means we can change the behavior in a derived class
        public virtual void Draw(){

        }
    }
}