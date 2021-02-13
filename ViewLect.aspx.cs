using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class ViewLect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);


            con.Open();
            MySqlCommand sda = new MySqlCommand("SELECT LecturerId FROM tablelecturer", con);
            MySqlDataReader dr;
            dr = sda.ExecuteReader();
            dropdown_lect_id.Items.Clear();
            while (dr.Read())
            {
                dropdown_lect_id.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdown_lect_id.DataBind();
            con.Close();
        }

        }
   
protected void btn_ok_Click(object sender, EventArgs e)
{
string connectionString = null;
        MySqlConnection con;
        connectionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connectionString);

        MySqlDataAdapter sdx = new MySqlDataAdapter("SELECT * FROM tablelecturer WHERE LecturerId='" + dropdown_lect_id.SelectedValue +  "'", con);
        System.Data.DataTable dt = new System.Data.DataTable();
        sdx.Fill(dt);
        try
        {
            lbl_lect_name.Visible = true;
            lbl_sub_name.Visible = true;
            lbl_department_id.Visible = true;
            lbl_batch_no.Visible = true;
           
            lbl_lectname.Visible = true;
            lbl_subject_name.Visible = true;
            lbl_dep_id.Visible = true;
            lbl_batchid.Visible = true;
            

            lbl_lectname.Text = dt.Rows[0][1].ToString();
            lbl_subject_name.Text = dt.Rows[0][2].ToString();
            lbl_dep_id.Text= dt.Rows[0][3].ToString();
            lbl_batchid.Text = dt.Rows[0][4].ToString();
          
        }
        catch (Exception ex)
        {
            lbl_lect_name.Visible = false;
            lbl_sub_name.Visible = false;
            lbl_department_id.Visible = false;
            lbl_batch_no.Visible = false;
       

            lbl_lectname.Visible = false;
            lbl_subject_name.Visible = false;
             lbl_dep_id.Visible = false;
            lbl_batchid.Visible = false;
            System.Windows.MessageBox.Show("No results found!");
            return;

        }
        con.Close();

}
protected void btn_clear_Click(object sender, EventArgs e)
{
  lbl_lect_name.Visible = false;
        lbl_lect_name.Visible = false;
         lbl_sub_name.Visible = false;
        lbl_department_id.Visible = false;
         lbl_batch_no.Visible = false;

        lbl_lectname.Visible = false;
         lbl_subject_name.Visible = false;
         lbl_dep_id.Visible = false;
        lbl_batchid.Visible = false;
    }
protected void btn_close_Click(object sender, EventArgs e)
{
    Response.Redirect("ResourceAllocation.aspx");
}
}
   
