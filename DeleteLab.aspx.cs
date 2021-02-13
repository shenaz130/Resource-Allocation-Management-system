using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

public partial class DeleteLab : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        string connectionstring = null;
        MySqlConnection con;
        connectionstring = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connectionstring);
        con.Open();
        string comm = "DELETE FROM lab WHERE LabId='" + txt_lab_id.Text + "'";
        MySqlCommand sda = new MySqlCommand(comm, con);
        sda.ExecuteNonQuery();
        System.Windows.MessageBox.Show("DONE");
        con.Close();
        Response.Redirect("main.aspx");
    }
}