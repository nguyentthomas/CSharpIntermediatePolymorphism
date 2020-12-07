using System;
namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (connectionString == null)
                throw new InvalidOperationException("ConnectionString can't be null");
            else if (connectionString == "")
                throw new InvalidOperationException("ConnectionString can't be empty");
            else if (Timeout == TimeSpan.FromSeconds(10))
                throw new Exception("Connection timed out.");
            else
                this.ConnectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
