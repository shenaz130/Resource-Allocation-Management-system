using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

public partial class AddLab : System.Web.UI.Page
{
  
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        string connectionString = null; 
        MySqlConnection con;
        connectionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connectionString);
        con.Open();
        string comm = "INSERT INTO lab(LabId, MaxCapacity, Subject_SubjectId) VALUES ('" +txt_lab_id.Text+ "', " + int.Parse(txt_max_capacity.Text)+ ", " + int.Parse(txt_sub_id.Text)+ ")";

        MySqlCommand sda = new MySqlCommand(comm, con);
        sda.ExecuteNonQuery();
        System.Windows.MessageBox.Show("DONE");
        con.Close();
        Response.Redirect("main.aspx");
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {

    }
}