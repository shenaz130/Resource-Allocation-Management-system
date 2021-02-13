using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btn_lecth_maint_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "student") == 0 || String.Compare(x,"lecturer")==0)
        {
            System.Windows.MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!");
        }
        else
        {
            Response.Redirect("LectHMaintanance.aspx");
        }
    }
    protected void btn_lect_maint_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "student") == 0 || String.Compare(x, "lecturer") == 0)
        {
            System.Windows.MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!");
        }
        else
        {
            Response.Redirect("LectureMaintanance.aspx");
        }
    }
    protected void btn_lab_maint_Click(object sender, EventArgs e)
    {
        string x = Session["Privilage"].ToString();
        if (String.Compare(x, "student") == 0 || String.Compare(x, "lecturer") == 0)
        {
            System.Windows.MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!");
        }
        else
        {
            Response.Redirect("LabMaintenance.aspx");
        }
    }
    protected void btn_resource_allo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ResourceAllocation.aspx");
    }
}