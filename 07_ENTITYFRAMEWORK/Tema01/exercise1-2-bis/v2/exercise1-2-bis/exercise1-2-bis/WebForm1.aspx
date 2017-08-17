<%@ Page Language="C#"    
    AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise1_2_bis.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Clientes: "></asp:Label>
        <asp:DropDownList ID="Customers"
            DataTextField="Name"
            DataValueField="Id"
            AutoPostBack="true"
            runat="server"></asp:DropDownList>
        <asp:Label ID="Label2" runat="server" Text="Productos: "></asp:Label>
        <asp:DropDownList ID="Products" runat="server"></asp:DropDownList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cantidad: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:GridView ID="Orders" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
