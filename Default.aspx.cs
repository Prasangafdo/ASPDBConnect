using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    SqlConnection con = new SqlConnection("Data Source=GAMEMAX;Initial Catalog=DBConnect;Integrated Security=True"); 
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand ("insert into new_Table values ('pppp', 'fffff', 'pswd')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Label1.Text = "Insert Success!";
    }
}