<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Magza.aspx.cs" Inherits="magza_urun_takip.Magza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="Button" Width="99px" />
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="190px" Width="251px"></asp:ListBox>
    </form>
</body>
</html>
