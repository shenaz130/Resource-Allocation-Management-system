<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LectHMaintanance.aspx.cs" Inherits="LectHMaintanance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 143px;
            height: 75px;
        }
    </style>
</head>
<body style="margin-left: 360px">
    <form id="form1" runat="server">
    <div style="height: 405px; width: 816px; margin-left: 40px;">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <img alt="" class="auto-style1" src="bcas.JPG" /><br />
        <br />
    
        <asp:Label ID="lbl_hall_maint" runat="server" style="font-size: x-large" Text="Lecture Hall Maintanance"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnadd" runat="server"   BackColor="PowderBlue" OnClick="btnadd_Click" Text="Add" Height="44px" Width="90px" />
        <br />
        <br /> 
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btndelete" runat="server"  BackColor="PowderBlue"  OnClick="btndelete_Click" Text="Delete" Height="35px" Width="83px" />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnview" runat="server"  BackColor="PowderBlue" Text="View" Height="42px" Width="83px" />
    
    </div>
    </form>
</body>
</html>
