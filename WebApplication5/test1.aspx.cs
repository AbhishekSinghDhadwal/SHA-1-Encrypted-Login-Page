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
    public partial class test1 : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["alliance_dataConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            String query1 = "INSERT INTO [dbo].[employee_data]([ID],[Name],[Password])VALUES(" + TextBox2.Text + ",'" + TextBox1.Text + "',HASHBYTES('SHA1','" + TextBox3.Text + "'))";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("test2.aspx");


        }
    }
}