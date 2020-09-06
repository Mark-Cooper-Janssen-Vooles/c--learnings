using System;
using System.Xml;

namespace InterfacesExtensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;


        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"migration started at {DateTime.Now}");
            //details of migrating db
            _logger.LogInfo($"migration finished at {DateTime.Now}");
        }
    }
}
