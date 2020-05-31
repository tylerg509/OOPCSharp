using System;
using static ObjectOrientedCSharp.Program;

namespace ObjectOrientedCSharp
{

    public class DbMigrator2
    {
        private readonly ILogger _logger;

        public DbMigrator2(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("migrating starting: " + DateTime.Now);
            _logger.LogInfo("migrating finished: " + DateTime.Now);
        }
    }

    
}
 