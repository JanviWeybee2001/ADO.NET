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
    public partial class load_update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = "data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sqlQuery = "select * from StudentInfo where StudentId = " + stuID.Text;
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Student");

                ViewState["SQL_QUERY"] = sqlQuery;
                ViewState["DATASET"] = ds;

                if(ds.Tables["Student"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Student"].Rows[0];
                    stuName.Text = dr["Full_Name"].ToString();
                    stuMarks.Text = dr["Total_Marks"].ToString();
                    stuGender.SelectedValue = dr["gender"].ToString();
                    status.Text = "";
                }
                else
                {
                    status.ForeColor = System.Drawing.Color.Red;
                    status.Text = "No Student record with ID = " + stuID.Text;
                    stuName.Text = "";
                    stuMarks.Text = "";
                    stuGender.SelectedValue = "-1";
                }
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string cs = "data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                // You must have to made a one UNIQUE key... of student id
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand((string)ViewState["SQL_QUERY"], con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                builder.DataAdapter = da;
                da.UpdateCommand = builder.GetUpdateCommand();
                

                DataSet ds = (DataSet)ViewState["DATASET"];

                if (ds.Tables["Student"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Student"].Rows[0];
                    dr["Full_Name"] = stuName.Text;
                    dr["Total_Marks"] = stuMarks.Text;
                    dr["gender"] = stuGender.SelectedValue;
                    status.Text = "";
                }

                int rowsUpdated = da.Update(ds, "Student");
                if (rowsUpdated > 0)
                {
                    status.ForeColor = System.Drawing.Color.Green;
                    status.Text = rowsUpdated.ToString() + " row(s) updates";
                }
                else
                {
                    status.ForeColor = System.Drawing.Color.Red;
                    status.Text = "0 row(s) updates";
                }

                stuName.Text = "";
                stuMarks.Text = "";
                stuGender.SelectedValue = "-1";

                lblDelete.Text = builder.GetDeleteCommand().CommandText;
                lblInsert.Text = builder.GetInsertCommand().CommandText;
                lblupdate.Text = builder.GetUpdateCommand().CommandText;
                con.Close();
            }
        }
    }
}


/* ----------------------------------------------------------SECOND METHOD OF UPDATE---------------------
    SqlCommand cmd = new SqlCommand("getStudentInfo", con);
    cmd.CommandType = System.Data.CommandType.StoredProcedure;
    cmd.Parameters.AddWithValue("@id", stuID.Text);
    cmd.Parameters.AddWithValue("@name", stuName.Text);
    cmd.Parameters.AddWithValue("@gender", stuGender.SelectedValue);
    cmd.Parameters.AddWithValue("@Marks", stuMarks.Text);
    con.Open();

    if (stuName.Text != "" && stuMarks.Text != "" && stuGender.SelectedValue != "-1")
    {
        int rowsUpdated = cmd.ExecuteNonQuery(); 
        if (rowsUpdated > 0)
        {
            status.ForeColor = System.Drawing.Color.Green;
            status.Text = rowsUpdated.ToString() + " row(s) updates";
        }
        else
        {
            status.ForeColor = System.Drawing.Color.Red;
            status.Text = "0 row(s) updates";
        }
    }
*/