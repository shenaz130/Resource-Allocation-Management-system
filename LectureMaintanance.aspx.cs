using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LectureMaintanance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddLect.aspx");
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "staff") == 0)
        {
            System.Windows.MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!");
        }
        else
        {
            Response.Redirect("DeleteLecturer.aspx");
        }
    }
}