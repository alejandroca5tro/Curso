<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>
<script type="text/javascript">
    function Saludar() {
        alert("Hola");
    }
</script>

<script runat="server">
    private void PonerMayuscula(object sender, EventArgs e)
    {
        string dato = Caja.Value;
        salida.InnerHtml = dato.ToUpper();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Poner en Mayúsculas</h1>
        <input type="text" id="Caja" runat="server"/>
        <input type="submit" id="btnAceptar" runat="server" onserverclick="PonerMayuscula" value="Proceder..." />
        <h3>Resultado:</h3>
        <span runat="server" id="salida"></span>

        <%--<asp:TextBox ID="Caja" runat="server"></asp:TextBox>--%>
        <%--<asp:Button ID="Button1" runat="server" Text="Button" />--%>
    </div>
    </form>
</body>
</html>