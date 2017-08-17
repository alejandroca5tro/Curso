<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practice02_0_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Ordenar por segundo apellido" OnClick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Nombres que comienzan por 'A'" OnClick="Button2_Click" />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Teléfono del contacto cuyo email es igual a ‘alguien@gmail.com" OnClick="Button3_Click" />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Contactos del estado “Alabama” y cuyo teléfono comience por 9
" OnClick="Button4_Click" />
        <br />
    </div>
    </form>
</body>
</html>
