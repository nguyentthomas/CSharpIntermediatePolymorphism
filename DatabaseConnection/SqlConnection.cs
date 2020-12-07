using System;
namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            Console.WriteLine("SqlServer works");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("SqlServer Connection closed, TODO: Actual Implementation");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SqlServer Connection opened, TODO: Actual Implementation");
        }
    }
}
