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
using System.Data;

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

            using(SqlConnection con11 = new SqlConnection("data source=JANVI-DESAI\\SQLEXPRESS; database=Sample; Integrated Security=SSPI"))
            {
                SqlCommand cmd11 = new SqlCommand("Select * from employee", con11);
                con11.Open();
                using (SqlDataReader rdr = cmd11.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID");
                    table.Columns.Add("FN");
                    table.Columns.Add("LN");
                    table.Columns.Add("Gender");
                    table.Columns.Add("Salary");
                    table.Columns.Add("Bonus");
                    while (rdr.Read())
                    {
                        DataRow dataRow = table.NewRow();
                        int OriginalSalary = Convert.ToInt32(rdr["Salary"]);
                        double bonus = OriginalSalary * 0.1;

                        dataRow["ID"] = rdr["EId"];
                        dataRow["FN"] = rdr["FirstName"];
                        dataRow["LN"] = rdr["LastName"];
                        dataRow["Gender"] = rdr["Gender"];
                        dataRow["Salary"] = OriginalSalary;
                        dataRow["Bonus"] = bonus;
                        table.Rows.Add(dataRow);
                    }
                    GridView1.DataSource = table;
                    GridView1.DataBind();
                }
     

                SqlCommand cmd112 = new SqlCommand("Select * from employee; Select * from student", con11);
                using(SqlDataReader rdr = cmd112.ExecuteReader())
                {
                    EmployeeGridView.DataSource = rdr;
                    EmployeeGridView.DataBind();

                    while(rdr.NextResult())
                    {
                        studentGridview.DataSource = rdr;
                        studentGridview.DataBind();
                    }
                }
            }
        }

        protected void spSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con11 = new SqlConnection("data source=JANVI-DESAI\\SQLEXPRESS; database=w3schools; Integrated Security=SSPI"))
            {
                SqlCommand cmd11 = new SqlCommand("spGetProductByName", con11);
                cmd11.CommandType = System.Data.CommandType.StoredProcedure;
                cmd11.Parameters.AddWithValue("@ProductName", spText.Text + "%");
                con11.Open();
                GridView4.DataSource = cmd11.ExecuteReader();
                GridView4.DataBind();
                con11.Close();
            }
        }



    }
}