namespace ObjectOrientedCSharp.InheritanceCompositionCompare.Composition
{

    class Program10
    {

        static void Main10(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();
        }

    }
}