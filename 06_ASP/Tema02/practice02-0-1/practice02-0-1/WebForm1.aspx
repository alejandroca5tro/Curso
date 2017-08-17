<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practice02_0_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Números menores de 5" OnClick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Suma total" OnClick="Button2_Click" />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Números menores de 5 sin repetir" OnClick="Button3_Click" />
    </div>
    </form>
</body>
</html>
