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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            if(Cache["Data"] == null)
            {
                string cs = "data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Cache["Data"] = ds;

                    GvEmployee.DataSource = ds;
                    GvEmployee.DataBind();
                }
                lblMessage.Text = "Data Loaded from the database";
            }
            else
            {
                GvEmployee.DataSource = (DataSet)Cache["Data"];
                GvEmployee.DataBind();

                lblMessage.Text = "Data Loaded from the Cache";
            }
        }
        protected void btnClearCache_Click(object sender, EventArgs e)
        {
            if(Cache["Data"]==null)
            {
                lblMessage.Text = "There is nothing in the Cache to be removed";
            }
            else
            {
                Cache.Remove("Data");
                lblMessage.Text = "The Dataset is removed from the Cache";
            }
        }
    }
}