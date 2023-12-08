using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VbcMobile
{
    internal class function 
    {
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-U9NHUOE\\SQLEXPRESS ; database = vbcbase; integrated security = True";
            return conn;
        }

        // to get data by using database
        //query = "select * from tablename";
        public DataSet GetData(String query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;  //by using this query, we can parse any quary by calling getData method. fench data will be return.
            SqlDataAdapter da = new SqlDataAdapter(cmd); // to store data set
            DataSet ds = new DataSet(); 
            da.Fill(ds);
            return ds;

        }

        public void setData (String query) //to insert, update, delete data 
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Success", "VBC Mobile Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

    }
}
