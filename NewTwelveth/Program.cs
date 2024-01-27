using System.Data;
using System.Data.SqlClient;

namespace NewTwelveth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADO "Active Data Object" => A way to work with database
            // 1- Connected Mode: ex: Select * from Employee (result of this query
            // at database engine is result set)
            // Is result set all returns from database? 
            // result = 1000 record 
            //disadvantage of this: multi requests
            // 2- Disconnected Mode: after results come from database to app, and app
            // will work with it, disadvantage of this: if big data come to client  => low performance

            //Connect app with databse => Connection, Commands

            SqlConnection sqlConnection = new SqlConnection("Data source =ABDULLAH; Database = Second;integrated security = True;TrustServerCertificate=True"); //;TrustServerCertificate=False
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            //sqlCommand.CommandText = "select * from Department";

            #region Connected Mode

            //sqlConnection.Open();
            #region Execute Query
            //SqlDataReader reader = sqlCommand.ExecuteReader(); // After this data at (database engine)
            //while (reader.Read())
            //{
            //    int id = (int)reader[0];
            //    string name = (string)reader[1];
            //    Console.WriteLine($"ID: {id} \t Name: {name}");
            //} 
            #endregion

            #region ExecuteScalar
            //sqlCommand.CommandText = "select count(*) from Department";
            //int count = (int)sqlCommand.ExecuteScalar(); 
            //Console.WriteLine(count); 
            #endregion

            #region ExecuteNonQuery
            //sqlCommand.CommandText = "delete Department where Dnumber > 85";
            //int rowsAffectedCount = (int)sqlCommand.ExecuteNonQuery(); 
            #endregion


            #region Stored Procedure
            //int salary = 1000;
            //sqlCommand.CommandText = $"exec [dbo].[procGetDepartments] {salary}";
            //sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("Dnumber", 10);


            //SqlDataReader reader = sqlCommand.ExecuteReader(); // After this data at (database engine)
            //while (reader.Read())
            //{
            //    int id = (int)reader[0];
            //    string name = (string)reader[1];
            //    Console.WriteLine($"ID: {id} \t Name: {name}");
            //}



            //sqlConnection.Close(); 
            #endregion

            #endregion


            #region Disconnected Mode

            //sqlCommand.CommandText = "select * from Department";
            //SqlDataAdapter adapter = new SqlDataAdapter(); // responseble for open connection, close connection and execution query
            //adapter.SelectCommand = sqlCommand;
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    int id = (int)row[0];
            //    string name = (string)row[1];
            //    Console.WriteLine($"ID: {id} \t Name: {name}");
            //}



            #endregion

        }
    }
}