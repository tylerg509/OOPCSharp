using System;

namespace ObjectOrientedCSharp
{

    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url){
            Console.WriteLine("added a link to " + url);
        }
    }

}