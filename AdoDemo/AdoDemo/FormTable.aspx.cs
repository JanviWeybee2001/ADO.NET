using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AdoDemo
{
    public partial class FormTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = "data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spADDEmployee", con);
                con.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FN", TextBox1.Text);
                cmd.Parameters.AddWithValue("@LN", TextBox2.Text);
                cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@salary", TextBox3.Text);
                Label1.Text = cmd.ExecuteNonQuery().ToString();
                con.Close();
            }
        }
    }
}