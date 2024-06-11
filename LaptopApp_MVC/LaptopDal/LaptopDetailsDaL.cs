using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LaptopDal
{
    

    public class LaptopDetailsDaL
    {
        SqlCommand cmd;
        SqlDataAdapter sda;

        public static SqlConnection Connect()

        {
            string connection = "Data Source=LAPTOP-ABL39IT0\\SQLEXPRESS;Initial Catalog=\"MVC Project\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();

            }
            return con;
        }

        public bool DMLOperation(String query)
        {
            cmd = new SqlCommand(query, LaptopDetailsDaL.Connect());
            int x = cmd.ExecuteNonQuery();
            if (x == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable SelectAll(string query)
        {
            sda = new SqlDataAdapter(query, LaptopDetailsDaL.Connect());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
