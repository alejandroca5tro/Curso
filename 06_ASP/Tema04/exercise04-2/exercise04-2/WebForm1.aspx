<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise04_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblNombre" runat="server" Text="Label" AssociatedControlID="txtNombre"></asp:Label>
        <br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblApellido" runat="server" Text="txtApellido" AssociatedControlID="txtApellido"></asp:Label>
        <br />
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkNet" runat="server" Text="Especialista .Net" />
        <br />
        <asp:CheckBox ID="chkPhp" runat="server" Text="Especialista PHP" />
        <br />
        <asp:CheckBox ID="chkJava" runat="server" Text="Especialista Java" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
