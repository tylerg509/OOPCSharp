using System;
using System.Collections.Generic;

namespace ObjectOrientedCSharp.PolymorphismOverridingMethods.TightCoupledExample
{
    public class Canvas2
    {
        public void DrawShape(List<Shape2> shapes)
        {
            foreach(var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType2.Circle:
                        Console.WriteLine("draw circle");
                        break;
                    case ShapeType2.Rectangle:
                        Console.WriteLine("draw rectangle");
                        break;
                }
            }
        }
    }
}