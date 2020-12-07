using System;
namespace DatabaseConnection
{
    public class DbCommand
    {
        public string _instruction;
        public DbConnection _connection;

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new InvalidOperationException("Connection can't be null");

            if (String.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Connection string cannot be empty");

            _connection = connection;
        }

        public void Execute(string instruction)
        {
            _connection.OpenConnection();
            InstructionRun(instruction);
            _connection.CloseConnection();
        }

        private void InstructionRun(string instruction)
        {
            _instruction = instruction;
            Console.WriteLine(instruction);

        }
    }
}
