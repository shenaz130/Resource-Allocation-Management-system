using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

public partial class AddLHall : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_ok_Click(object sender, EventArgs e)
    {
        bool IT, BM, BIO;

        if (string.Compare(dropdown_it.SelectedValue,"Yes")==0)
        {
            IT = true;
        }
        else
        {
            IT = false;
        }

        if (string.Compare(dropdown_bm.SelectedValue, "Yes") == 0)
        {
            BM = true;
        }
        else
        {
            BM = false;
        }

        if (string.Compare(dropdown_bio.SelectedValue, "Yes") == 0)
        {
            BIO = true;
        }
        else
        {
            BIO = false;
        }
        string connectionString = null;
        MySqlConnection con;
        connectionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connectionString);
        con.Open();
        string comm = "INSERT INTO lhall (LhallId, IT, BM, BIO, MaxCapacity, Subject_SubjectId) VALUES ('"+txt_lect_hall_id.Text+"', "+IT+", "+BM+","+BIO+","+int.Parse(txt_max_capacity.Text)+","+int.Parse(txt_sub_id.Text)+")";

        MySqlCommand sda = new MySqlCommand(comm, con);
        sda.ExecuteNonQuery();
        System.Windows.MessageBox.Show("DONE");
        con.Close();
        Response.Redirect("main.aspx");
    }
}