<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResourceAllocation.aspx.cs" Inherits="ResourceAllocation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 67px;
            width: 122px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 411px; width: 833px; margin-left: 360px;">
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <img alt="" class="auto-style1" src="bcas.JPG" /><br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="RESOURCE ALLOCATION"></asp:Label>
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Button ID="btn_book_lect_hall" runat="server" BackColor="PowderBlue" OnClick="btn_book_lect_hall_Click" Text="Book Lecture Hall" Height="62px" Width="175px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_book_lab" runat="server" OnClick="btn_book_lab_Click" Text="Book Lab"  BackColor="PowderBlue" CssClass="auto-style1" Width="151px" Height="60px" />
    
        <br />
    
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_view_lect_hall" runat="server" Text="View Lecture Hall" BackColor="PowderBlue" OnClick="btn_view_lect_hall_Click" Height="55px" Width="164px" />
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_view_lab" runat="server" Text="View Lab" OnClick="btn_view_lab_Click" BackColor="PowderBlue" Height="57px" Width="145px" />
    
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        
    
    </div>
    </form>
</body>
</html>
