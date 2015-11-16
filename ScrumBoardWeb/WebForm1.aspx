<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebScrum.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Story"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="To Do"></asp:Label>
    
    </div>
        <asp:ListBox ID="lsBox1" runat="server" Height="64px" Width="74px">
            <asp:ListItem>Test</asp:ListItem>
        </asp:ListBox>
        <asp:ListBox ID="lsbox2" runat="server" Height="65px" Width="83px"></asp:ListBox>

        <div>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
        </div>
    </form>
</body>
</html>
