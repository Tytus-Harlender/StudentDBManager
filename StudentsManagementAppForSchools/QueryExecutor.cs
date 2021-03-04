using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace StudentsManagementAppForSchools
{
    public class QueryExecutor
    {
        public int executeQuery(string query)
        {
            int rowCount;
            string connString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Sales;Integrated Security=True;Pooling=False";
            SqlConnection sqlConnection = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandTimeout = 3660;
            try
            {
                sqlConnection.Open();
                rowCount = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("The query has not been resolved");
                throw e;
            }
            return rowCount;
        }
    }
}
