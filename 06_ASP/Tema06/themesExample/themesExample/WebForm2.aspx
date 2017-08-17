<%@ Page Language="C#" AutoEventWireup="true" StylesheetTheme="Nacional" CodeBehind="WebForm2.aspx.cs" Inherits="themesExample.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nombre:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Text="Opción 1" Value="1"></asp:ListItem>
            <asp:ListItem Text="Opción 2" Value="1"></asp:ListItem>
            <asp:ListItem Text="Opción 3" Value="1"></asp:ListItem>
        </asp:RadioButtonList>
        <asp:TextBox ID="TextBox2" SkinID="cajaRoja" runat="server"></asp:TextBox>

        <asp:TextBox ID="TextBox4" EnableTheming="false" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
