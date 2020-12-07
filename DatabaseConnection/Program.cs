using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseDbCommand();
            
        }

        static void ExerciseDbCommand()
        {
            //Sql Server
            string stringConnection = "ConnectString";
            string instruction = "SELECT * FROM table";
            var sqlServerConnect = new SqlConnection(stringConnection);
            var dbCommand = new DbCommand(sqlServerConnect, instruction);
            dbCommand.Execute(instruction);


            //Oracle

            var oracleConnection = new OracleConnection(stringConnection);
            var dbCommandOracle = new DbCommand(oracleConnection, instruction);
            dbCommandOracle.Execute(instruction);
        }
    }
}
