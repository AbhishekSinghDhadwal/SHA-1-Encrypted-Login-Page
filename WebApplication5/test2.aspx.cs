using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication5
{
    public partial class test2 : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["alliance_dataConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            String query1 = "SELECT COUNT (*) FROM employee_data WHERE Password= HASHBYTES('SHA1', '" + TextBox2.Text + "') AND ID=" +TextBox1.Text+ "";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            con.Open();
            int count = Convert.ToInt32(cmd1.ExecuteScalar());
            if (count == 1)
            {
                Response.Redirect("test3.aspx");
            }
            else
            {
                Label1.Text = "Invalid Input, kindly try again";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            con.Close();

        }
    }
}