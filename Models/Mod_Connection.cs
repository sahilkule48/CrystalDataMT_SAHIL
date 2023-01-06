using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CrystalDataMT_SAHIL.Models
{
    public class Mod_Connection
    {
        static string sqlstring = @"Data Source=103.131.93.13\ETest,1433;Initial Catalog=ETest;user=ETest;password=Power@123;Connection Timeout=100000";
        //static string sqlstring = @"Data Source=DESKTOP-1MED2NB\SQLEXPRESS;Initial Catalog=101_2223;user=sa;password=jay@321;Connection Timeout=100000";
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static DataTable returndata(string query)
        {
            con = new SqlConnection(sqlstring);
            con.Close();
            con.Open();
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
            //con.Close();
        }
    }
}