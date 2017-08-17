<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="example07_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="ProductID:"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>    
        <br />

        <asp:Button ID="Button1" runat="server" Text="Unidades en Stock" OnClick="Button1_Click" />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Unidades en Stock:"></asp:Label>
        <asp:TextBox ID="txtUnidades" runat="server"></asp:TextBox>    
        <br />
    </div>
    </form>
</body>
</html>
