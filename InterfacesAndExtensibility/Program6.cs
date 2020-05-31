
namespace ObjectOrientedCSharp.InterfacesAndExtensibility
{
    partial class Program6
    {

        static void Main6(string[] args)
        {

            var dbMigrator = new DbMigrator2(new ConsoleLogger());
            var fileLogger = new DbMigrator2(new FileLogger("C:\\log.txt"));

            dbMigrator.Migrate();
            fileLogger.Migrate();
        }

    }
}