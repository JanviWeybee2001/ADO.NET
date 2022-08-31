using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdoDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = "data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from student", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();

                SqlDataAdapter da1 = new SqlDataAdapter("spGetEmployee", con);
                da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                tblStoredProcedure.DataSource = ds1;
                tblStoredProcedure.DataBind();

                SqlDataAdapter da2 = new SqlDataAdapter("spGetData", con);
                da2.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                GridView3.DataSource = ds2.Tables[0];
                GridView3.DataBind();

                GridView4.DataSource = ds2.Tables[1];
                GridView4.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = "data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("spGetEmployeeById", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id", TextBox1.Text);
                DataSet ds = new DataSet();
                da.Fill(ds);

                GridView2.DataSource = ds;
                GridView2.DataBind();
            }
        }
    }
}