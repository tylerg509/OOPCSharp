using System.Collections.Generic;
using System;

namespace ObjectOrientedCSharp
{
    public class Canvas
    {
        public void DrawShape(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                // Due to polymorphic implentation, calling draw() will envoke different implementation based on the shape type
                shape.Draw();
            }
        }
    }
}