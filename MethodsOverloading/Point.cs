using System;

namespace ObjectOrientedCSharp
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation) 
        {
            if(newLocation == null)
                throw new ArgumentNullException("newLocation");
            Move(newLocation.X, newLocation.Y);
            // Replace the below with a call to the method above
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }
    }
    
}