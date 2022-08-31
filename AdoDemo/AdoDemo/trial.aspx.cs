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
    public partial class trial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void GetDataromDB()
        {
            string cs = "data source=JANVI-DESAI\\SQLEXPRESS; database=MOVIES_W3; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(cs);
            string strSelectQuery = "Select * from actor";
            SqlDataAdapter da = new SqlDataAdapter(strSelectQuery, con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Actor");

            ds.Tables["Actor"].PrimaryKey = new DataColumn[] { ds.Tables["Actor"].Columns["act_id"] };
            Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);

            gvStudent.DataSource = ds;
            gvStudent.DataBind();
        }

        private void GetDataFromCache()
        {
            if (Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];

                gvStudent.DataSource = ds;
                gvStudent.DataBind();
            }
        }

        protected void gvStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if(Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                DataRow dr = ds.Tables["Actor"].Rows.Find(e.Keys["act_id"]);
                dr["act_fname"] = e.NewValues["act_fname"];
                dr["act_lname"] = e.NewValues["act_lname"];
                dr["act_gender"] = e.NewValues["act_gender"];

                Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                gvStudent.EditIndex = -1;
                GetDataFromCache();
            }
        }

        protected void gvStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvStudent.EditIndex = -1;
            GetDataFromCache();
        }

        protected void gvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                DataRow dr = ds.Tables["Actor"].Rows.Find(e.Keys["act_id"]);
                dr.Delete();

                Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                GetDataFromCache();
            }
        }

        protected void gvStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStudent.EditIndex = e.NewEditIndex;
            GetDataFromCache();
        }

        protected void Get_Data_Click(object sender, EventArgs e)
        {
            GetDataromDB();
        }
    }
}