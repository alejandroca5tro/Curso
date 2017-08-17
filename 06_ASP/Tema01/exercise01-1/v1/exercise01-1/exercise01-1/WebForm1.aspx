<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise01_1.WebForm1" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script>

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
      

        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
        <br />
        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <br />
    </div>
    </form>
</body>
</html>
