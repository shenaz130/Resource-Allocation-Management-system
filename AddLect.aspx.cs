using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



public partial class lect_maintanance : System.Web.UI.Page
{
    protected void btn_add_Click(object sender, EventArgs e)
    {
        string connectionString = null;
        MySqlConnection con;
        connectionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connectionString);
        con.Open();
        string comm = "INSERT INTO tablelecturer(LecturerId, LecturerName, LecturerSubject, Department_DepartmentId, Batch_BatchId)  VALUES (" + int.Parse(txt_lect_id.Text) + ",'" + txt_lect_name.Text + "', '"+txt_sub.Text+"'," + int.Parse(txt_depart_id.Text)+ ",'" + txt_batch_no.Text + "')";

        MySqlCommand sda = new MySqlCommand(comm, con);
        sda.ExecuteNonQuery();
        System.Windows.MessageBox.Show("DONE");
        con.Close();
        Response.Redirect("main.aspx");
    }
}