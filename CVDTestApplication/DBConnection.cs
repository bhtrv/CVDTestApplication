using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CVDTestApplication
{
    class DBConnection
    {
        private static string GetConnectionString()
        {
            const string server = @"127.0.0.1";
            const string database = @"cvddb";
            const string uid = @"root";
            const string pwd = @"root";
            return @"server=" + server + ";uid=" + uid + ";pwd=" + pwd + ";database=" + database;
        }

        public static DataTable Query(MySqlCommand cmd)
        {
            DataTable dt = new DataTable();
            MySqlConnection sqlConnection = new MySqlConnection(GetConnectionString());
            MySqlDataAdapter sda = new MySqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                sqlConnection.Close();
                sda.Dispose();
                sqlConnection.Dispose();
            }
        }

        public static DataTable GetDataFromSql(string query)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query);
            dt = Query(cmd);
            return dt;
        }
    }
}