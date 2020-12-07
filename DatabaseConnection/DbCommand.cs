using System;
namespace DatabaseConnection
{
    public class DbCommand
    {
        string Instruction = "SQL instruction goes here... TODO: Actual Implementation";

        public DbCommand()
        {
            
            
        }

        public void Execute()
        {
            var Dbcon = new SqlConnection();
            Dbcon.OpenConnection();

            Dbcon.CloseConnection();

            var DbOracleCon = new OracleConnection();
            DbOracleCon.OpenConnection();

            DbOracleCon.CloseConnection();

        }
    }
}
