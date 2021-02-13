using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResourceAllocation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_book_lect_hall_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "student") == 0 || String.Compare(x, "lecturer") == 0)
        {
            System.Windows.MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!");
        }
        else
        {
            Response.Redirect("BookLectHall.aspx");
        }
    }
    protected void btn_book_lab_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "student") == 0 || String.Compare(x, "lecturer") == 0)
        {
            System.Windows.MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!");
        }
        else
        {
            Response.Redirect("BookLab.aspx");
        }
    }
    protected void btn_view_lect_hall_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBookedLHall.aspx");
    }
    protected void btn_view_lab_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBookedLab.aspx");
    }
}