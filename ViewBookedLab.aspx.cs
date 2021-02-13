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

            System.Data.DataTable datedrop = new System.Data.DataTable();
            datedrop.Columns.Add(new System.Data.DataColumn("Dates"));
            datedrop.Rows.Add(System.DateTime.Today.ToShortDateString());

            for (int i = -7; i < 7; i++)
            {
                datedrop.Rows.Add(System.DateTime.Today.AddDays(i).ToShortDateString());
            }

            dropdown_date.DataSource = datedrop;
            dropdown_date.DataTextField = datedrop.Columns["Dates"].ToString();
            dropdown_date.DataBind();

            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);


            con.Open();
            MySqlCommand sda = new MySqlCommand("SELECT LabId FROM lab", con);
            MySqlDataReader dr;
            dr = sda.ExecuteReader();
            dropdown_Lab_id.Items.Clear();
            while (dr.Read())
            {
                dropdown_Lab_id.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdown_Lab_id.DataBind();
            con.Close();

        }
    }
   

    protected void btn_ok_Click(object sender, EventArgs e)
    {
        string connectionString = null;
        MySqlConnection con;
        connectionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connectionString);
       

        MySqlDataAdapter sdx = new MySqlDataAdapter("SELECT * FROM labbooking WHERE LabId='" + dropdown_Lab_id.SelectedValue + "' AND BookingDate='" + dropdown_date.SelectedValue + "' AND BookingTime='" + dropdown_time.SelectedValue + "'", con);
        System.Data.DataTable dt = new System.Data.DataTable();
        sdx.Fill(dt);
        try
        {
            lbl_lect_name.Visible = true;
            lbl_lect_name0.Visible = true;
            lbl_batch_no.Visible = true;
            lbl_sub_name.Visible = true;
            lbl_participant.Visible = true;

            lbl_lectname.Visible = true;
            lbl_lectid.Visible = true;
            lbl_batchid.Visible = true;
            lbl_subject_name.Visible = true;
            lbl_participants.Visible = true;

            lbl_lectname.Text = dt.Rows[0][4].ToString();
            lbl_lectid.Text = dt.Rows[0][5].ToString();
            lbl_batchid.Text = dt.Rows[0][7].ToString();
            lbl_subject_name.Text = dt.Rows[0][6].ToString();
            lbl_participants.Text = dt.Rows[0][3].ToString();
        }
        catch (Exception ex)
        {
            lbl_lect_name.Visible = false;
            lbl_lect_name0.Visible = false;
            lbl_batch_no.Visible = false;
            lbl_sub_name.Visible = false;
            lbl_participant.Visible = false;

            lbl_lectname.Visible = false;
            lbl_lectid.Visible = false;
            lbl_batchid.Visible = false;
            lbl_subject_name.Visible = false;
            lbl_participants.Visible = false;
            System.Windows.MessageBox.Show("No results found!");
            return;

        }
        con.Close();

    }

    protected void btn_clear_Click(object sender, EventArgs e)
    {
        lbl_lect_name.Visible = false;
        lbl_lect_name0.Visible = false;
        lbl_batch_no.Visible = false;
        lbl_sub_name.Visible = false;
        lbl_participant.Visible = false;

        lbl_lectname.Visible = false;
        lbl_lectid.Visible = false;
        lbl_batchid.Visible = false;
        lbl_subject_name.Visible = false;
        lbl_participants.Visible = false;
    }
    protected void btn_close_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResourceAllocation.aspx");
    }
}