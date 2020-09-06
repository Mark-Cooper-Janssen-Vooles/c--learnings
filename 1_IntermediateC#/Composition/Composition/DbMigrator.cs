namespace Composition
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger; //creates association to logger classs
        }

        public void Migrate()
        {
            _logger.Log("We are migrating blah blah");
        }

    }
}
