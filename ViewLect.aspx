<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewLect.aspx.cs" Inherits="ViewLect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            margin-top: 9px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 463px; width: 808px; margin-left: 200px;">
    
        <asp:Label ID="lbl_view_lect_hall" runat="server" style="font-size: x-large" Text="View Of Lecture Hall Details"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_lect_id" runat="server" Text="Lecture ID"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="dropdown_lect_id" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_ok" runat="server"  Text="Retrieve" OnClick="btn_ok_Click" CssClass="auto-style2" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="auto-style1" Height="22px" OnClick="btn_clear_Click" />
        
    
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_close" runat="server" Text="Close" CssClass="auto-style1" Height="22px" OnClick="btn_close_Click" />
        
    
        <br />
        <br />
        <br />
        <asp:Label ID="lbl_lect_name" runat="server" Text="Lecture Name" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_lectname" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_sub_name" runat="server" Text="Subject Name" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_subject_name" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_department_id" runat="server" Text="department ID" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_dep_id" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_batch_no" runat="server" Text="Batch ID" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_batchid" runat="server"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
    
    </div>
    </form>
</body>
</html>
