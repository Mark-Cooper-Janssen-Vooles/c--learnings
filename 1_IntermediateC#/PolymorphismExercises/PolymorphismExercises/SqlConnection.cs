namespace PolymorphismExercises
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            System.Console.WriteLine($"opening SqlConnection {base._connectionString}");
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("closing sql connection");
        }
    }
}
