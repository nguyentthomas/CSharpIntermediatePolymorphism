using System;
namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString)
        {
            Console.WriteLine("OracleConnection works");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection closed - TODO: Oracle Connection API");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection opened - TODO: Oracle Connection API");
        }
    }
}
