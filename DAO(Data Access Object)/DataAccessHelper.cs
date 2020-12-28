using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAO_Data_Access_Object_
{
    public class DataAccessHelper
    {   public static string ConnectionString= ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;

        internal static DataTable exc(string cmdtext)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlDataAdapter cmd = new SqlDataAdapter(cmdtext, conn);


            DataTable dt = new DataTable();
            conn.Close();
            cmd.Fill(dt);
            return dt;
            
        }
        public static void execCmd(string sql)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}