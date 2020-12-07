using System;
namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        string ConnectionString = "Potato";
        readonly TimeSpan Timeout;

        public DbConnection()
        {
            if (ConnectionString == null)
                throw new InvalidOperationException("ConnectionString can't be null");
            else if (ConnectionString == "")
                throw new InvalidOperationException("ConnectionString can't be empty");
            else if (Timeout == TimeSpan.FromSeconds(10))
                throw new Exception("Connection timed out.");
            else
                Console.WriteLine("Connection String Valid");
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
