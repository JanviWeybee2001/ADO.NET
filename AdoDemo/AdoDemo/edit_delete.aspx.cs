using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AdoDemo
{
    public partial class edit_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetDataromDB()
        {
            string cs = "data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(cs);
            string strSelectQuery = "Select * from StudentInfo";
            SqlDataAdapter da = new SqlDataAdapter(strSelectQuery, con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Students");

            ds.Tables["Students"].PrimaryKey = new DataColumn[] { ds.Tables["Students"].Columns["StudentId"] };
            Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);

            gvStudent.DataSource = ds;
            gvStudent.DataBind();

            lblMessage.Text = "Data Loaded from Database";
        }

        private void GetDataFromCache()
        {
            if(Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];

                gvStudent.DataSource = ds;
                gvStudent.DataBind();
            }
        }

        protected void btnGetDataFromDB_Click(object sender, EventArgs e)
        {
            GetDataromDB();
        }

        protected void gvStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStudent.EditIndex = e.NewEditIndex;
            GetDataFromCache();
        }

        protected void gvStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gvStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void gvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}