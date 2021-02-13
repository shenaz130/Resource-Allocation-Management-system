using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_ok_Click(object sender, EventArgs e)
    {
        string connetionString = null;
        MySqlConnection con;
        connetionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connetionString);

        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT Privilage FROM user WHERE UserID='" + txt_username.Text + "' AND Password='" + txt_password.Text + "'", con);
        System.Data.DataTable dt = new System.Data.DataTable();
        sda.Fill(dt);
        try
        {
            Session["Privilage"] = dt.Rows[0][0].ToString();
            Response.Redirect("main.aspx");
        }
        catch (IndexOutOfRangeException ex)
        {
            System.Windows.MessageBox.Show("Invalid username or password");
        }
        con.Close();
       
    }
}