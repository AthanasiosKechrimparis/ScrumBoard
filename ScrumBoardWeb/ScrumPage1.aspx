<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScrumPage1.aspx.cs" Inherits="ScrumBoardWeb.ScrumPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-style: italic" Text="Story"></asp:Label>
    
    </div>
        <asp:ListBox ID="listOFtASK" runat="server" AutoPostBack="True">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
    </form>
</body>
</html>
