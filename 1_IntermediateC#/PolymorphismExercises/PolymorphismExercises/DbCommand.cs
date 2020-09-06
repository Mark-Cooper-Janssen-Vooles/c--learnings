using System;

namespace PolymorphismExercises
{
    public class DbCommand
    {
        public DbConnection DbConnection { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new Exception("dbConnection is null");

            DbConnection = dbConnection;

            if (String.IsNullOrWhiteSpace(instruction))
                throw new Exception("instruction is null or whitespace");

            Instruction = instruction;
        }

        public void Execute()
        {
            DbConnection.OpenConnection();
            Console.WriteLine(Instruction);
            DbConnection.CloseConnection();
        }
    }
}
