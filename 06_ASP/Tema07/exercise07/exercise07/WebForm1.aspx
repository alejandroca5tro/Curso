<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise07.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Seleccionar país:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <hr />
        <asp:Label ID="Label2" runat="server" Text="Clientes por país:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>          
    </div>
    </form>
</body>
</html>
