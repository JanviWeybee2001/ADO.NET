using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Configuration;

namespace AdoDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI;");
            SqlCommand cmd2 = new SqlCommand("Select * from student", con2);
            con2.Open();
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            GridView2.DataSource = rdr2;
            GridView2.DataBind();
            con2.Close();


            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //using (SqlConnection con1 = new SqlConnection(cs))
            //{
            //    SqlCommand cmd1 = new SqlCommand("Select * from orders", con1);
            // also , we can write this sentence by two method..
            //---------------------------------------------------------------
            //// Sqlcommand cmd1 = new SqlCommand();
            //cmd1.CommandText = "Select * from orders";
            //cmd1.Connection = con1;
            //---------------------------------------------------------------

            //    con1.Open();   // now, it is give the error but it'll work.
            //    SqlDataReader rdr1 = cmd1.ExecuteReader();
            //    GridView1.DataSource = rdr1;
            //    GridView1.DataBind();
            //} // Here, connection close it self.

            //by use of 'using' keyword .. we don't have to close the connection


            SqlConnection con = new SqlConnection("data source=JANVI-DESAI\\SQLEXPRESS; database=w3schools; Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("select count(ProductID) from products",con);
            con.Open();
            GridView3.DataSource = cmd.ExecuteReader();
            GridView3.DataBind();
            con.Close();
            

        }
    }
}