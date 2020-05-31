using System.Collections.Generic;

namespace ObjectOrientedCSharp
{
    partial class Program
    {

        static void Main(string[] args)
        {

            var dbMigrator = new DbMigrator2(new ConsoleLogger());
            var fileLogger = new DbMigrator2(new FileLogger("C:\\log.txt"));

            dbMigrator.Migrate();
            fileLogger.Migrate();
        }

    }
}