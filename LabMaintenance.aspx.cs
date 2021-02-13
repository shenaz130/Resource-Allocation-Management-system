using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lab_Maintainance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_delete_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "staff") == 0)
        {
            System.Windows.MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!");
        }
        else
        {
            Response.Redirect("DeleteLab.aspx");
        }
    }
    protected void btn_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddLab.aspx");
    }

    protected void btn_view_Click(object sender, EventArgs e)
    {

    }
}