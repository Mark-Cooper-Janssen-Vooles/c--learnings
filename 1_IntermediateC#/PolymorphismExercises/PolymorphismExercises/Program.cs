using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("1234");
            //sqlConnection.OpenConnection();
            //sqlConnection.CloseConnection();

            var oracleConnection = new OracleConnection("hmm");
            //oracleConnection.OpenConnection();
            //oracleConnection.CloseConnection();

            var dbCommand = new DbCommand(oracleConnection, "delete users");
            dbCommand.Execute();
        }
    }
}
