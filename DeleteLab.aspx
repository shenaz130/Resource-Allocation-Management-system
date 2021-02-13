<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteLab.aspx.cs" Inherits="DeleteLab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 166px;
            height: 97px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 320px">
            &nbsp;</p>
        <p style="margin-left: 320px">
            &nbsp;</p>
        <p style="margin-left: 320px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl_del_lab" runat="server" style="font-size: x-large" Text="DELETE LAB"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img alt="" class="auto-style1" src="bcas.JPG" /></p>
        <p style="margin-left: 320px">
            <br />
            <br />
            <asp:Label ID="lbl_lab_id" runat="server" Text="Lab ID"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_lab_id" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
        </p>
        <p style="margin-left: 320px">
            &nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="Delete" />
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
