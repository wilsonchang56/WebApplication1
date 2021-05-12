<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test3.aspx.cs" Inherits="WebApplication1.test3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/scissors.png" OnClick="Button_Click" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/stone.png" OnClick="Button_Click" />
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/paper.png" OnClick="Button_Click" />
    </br>
    <asp:Label ID="userResult" runat="server"></asp:Label>
    </br>
    <asp:Image ID="computerImage" runat="server" BorderStyle="None" Height="138px" Width="153px" />
        <asp:Label ID="Label1" runat="server" Text="count"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="203px"></asp:TextBox>
        <asp:Button ID="Send" runat="server" Text="Button" OnClick="Send_Click" />
        </br>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> 
        </br>
    <asp:Label ID="computerResult" runat="server"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged"   />1.長澤直美
    </br>
    <asp:Label ID="final" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label> 
    <asp:Button ID="Button2" runat="server" Text="Exit" OnClick="Button2_Click" />    
        <asp:Timer ID="Timer2" runat="server" Interval="1000" OnTick="Timer2_Tick"></asp:Timer> 
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </form>
</body>
</html>
