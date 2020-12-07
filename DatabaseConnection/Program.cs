using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseDbConnection();
            
        }

        static void ExerciseDbConnection()
        {
            //Sql Server

            var Dbcon = new SqlConnection();
            Dbcon.OpenConnection();
            Dbcon.CloseConnection();

            //Oracle

            var DbOracleCon = new OracleConnection();
            DbOracleCon.OpenConnection();
            DbOracleCon.CloseConnection();
        }
    }
}
