using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class BookLectHall : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            System.Data.DataTable datedrop = new System.Data.DataTable();
            datedrop.Columns.Add(new System.Data.DataColumn("Dates"));
            datedrop.Rows.Add(System.DateTime.Today.ToShortDateString());

            for (int i = 1; i < 7; i++)
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
            dropdown_lab_id.Items.Clear();
            while (dr.Read())
            {
                dropdown_lab_id.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdown_lab_id.DataBind();
            con.Close();


            con.Open();
            sda = new MySqlCommand("SELECT LecturerName FROM tablelecturer", con);
            dr = sda.ExecuteReader();
            dropdown_lect_name.Items.Clear();
            while (dr.Read())
            {
                dropdown_lect_name.Items.Add(new ListItem(dr[0].ToString(), dr[0].ToString()));
            }
            dropdown_lect_name.DataBind();

            con.Close();
        }
    }
    protected void dropdown_lect_name_SelectedIndexChanged(object sender, EventArgs e)
    {
        string connetionString = null;
        MySqlConnection con;
        connetionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connetionString);

        con.Open();
        MySqlCommand sda = new MySqlCommand("SELECT LecturerID FROM tablelecturer where LecturerName = '" + dropdown_lect_name.Text + "'", con);
        MySqlDataReader dr;
        dr = sda.ExecuteReader();
        dr.Read();
        lbl_lec_id.Text = dr["LecturerID"].ToString();
        con.Close();

    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        string connectionString = null;
        MySqlConnection con;
        connectionString = "server=localhost;database=mydb;Uid=root;Pwd=;";
        con = new MySqlConnection(connectionString);

        MySqlDataAdapter sdx = new MySqlDataAdapter("SELECT COUNT(*) FROM labbooking WHERE LabId='" + dropdown_lab_id.SelectedValue + "' AND BookingDate='" + dropdown_date.SelectedValue + "' AND BookingTime='" + dropdown_time.SelectedValue + "'", con);
        System.Data.DataTable dt = new System.Data.DataTable();
        sdx.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {
            System.Windows.MessageBox.Show("Lab already booked!");
            return;
        }

        con.Close();


        sdx = new MySqlDataAdapter("SELECT COUNT(*) FROM labbooking WHERE LecturerName='" + dropdown_lect_name.SelectedValue + "' AND BookingDate='" + dropdown_date.SelectedValue + "' AND BookingTime='" + dropdown_time.SelectedValue + "'", con);
        dt = new System.Data.DataTable();
        sdx.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {
            System.Windows.MessageBox.Show("Selected Lecturer is already booked!");
            return;
        }

        con.Close();

        sdx = new MySqlDataAdapter("SELECT COUNT(*) FROM labbooking WHERE LecturerName='" + dropdown_lect_name.SelectedValue + "' AND BookingDate='" + dropdown_date.SelectedValue + "' AND BookingTime='" + dropdown_time.SelectedValue + "'", con);
        dt = new System.Data.DataTable();
        sdx.Fill(dt);
        if (dt.Rows[0][0].ToString() == "1")
        {
            System.Windows.MessageBox.Show("Selected Lecturer is already booked!");
            return;
        }

        con.Close();

        con.Open();
        MySqlCommand sda = new MySqlCommand("SELECT MaxCapacity FROM lab where labId = '" + dropdown_lab_id.SelectedValue + "'", con);
        MySqlDataReader dr;
        dr = sda.ExecuteReader();
        dr.Read();
        int maxcap = Convert.ToInt32(dr["MaxCapacity"].ToString());
        if(maxcap<Convert.ToInt32(txt_participants.Text))
        {
            System.Windows.MessageBox.Show("The participants have exceeded the maximum capacity!");
            return;
        }
        con.Close();

  
        DateTime date = Convert.ToDateTime(dropdown_date.SelectedValue);
        string d = date.ToShortDateString();

        con.Open();
        string comm = "INSERT INTO labbooking (BookingDate, BookingTime, LabId, Participants, LecturerName, LecturerId, BatchId) VALUES ('"+d+"', '"+dropdown_time.SelectedValue+"', '"+dropdown_lab_id.SelectedValue+"', '"+txt_participants.Text+"', '"+dropdown_lect_name.SelectedValue+"', '"+lbl_lec_id.Text+"',  '"+txt_batch_id.Text+"')";
        sda = new MySqlCommand(comm, con);
        sda.ExecuteNonQuery();
        System.Windows.MessageBox.Show("DONE");
        con.Close();
        Response.Redirect("main.aspx");

    }
}
    
