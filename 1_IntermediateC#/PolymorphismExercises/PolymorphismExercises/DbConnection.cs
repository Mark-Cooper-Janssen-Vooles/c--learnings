using System;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        public string _connectionString { get; set; }
        private TimeSpan _timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new Exception("connection string is null or white space");

            _connectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
