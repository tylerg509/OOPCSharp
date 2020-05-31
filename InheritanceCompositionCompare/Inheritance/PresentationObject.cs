using System;

namespace ObjectOrientedCSharp
{
    public class PresentationObject
    {
        public int width {get; set;}
        public int Height {get;set;}

        public void Copy(){
            Console.WriteLine("object copied to clipboard");
        }

        public void Duplicate(){
            Console.WriteLine("object duplicated");
        }
    }
}