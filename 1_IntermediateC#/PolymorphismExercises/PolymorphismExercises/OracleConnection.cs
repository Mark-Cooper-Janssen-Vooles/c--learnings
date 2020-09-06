namespace PolymorphismExercises
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            System.Console.WriteLine($"opening Oracle Connection {base._connectionString}");
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("closing oracle connection");
        }
    }
}
