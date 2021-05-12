<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test2.aspx.cs" Inherits="WebApplication1.test2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>                                                                                                 
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="name" runat="server"></asp:TextBox> 
        </br>
        
           <input type="text" id="user" name="user2"><br />
            <asp:Label ID="userLabel" runat="server" Text="Label"></asp:Label>
        </br>
        <asp:TextBox ID="passwd" runat="server"></asp:TextBox>
        <asp:Label ID="passwdLabel" runat="server" Text="Label"></asp:Label>
        </br>
        <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ordersConnectionString2 %>" SelectCommand="SELECT * FROM [account]"></asp:SqlDataSource>
       
    </form>
</body>
</html>
