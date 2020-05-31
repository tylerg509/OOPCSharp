using System;
using static ObjectOrientedCSharp.Program;

namespace ObjectOrientedCSharp
{

    public class ConsoleLogger : ILogger 
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
        }

    }

    
}
 