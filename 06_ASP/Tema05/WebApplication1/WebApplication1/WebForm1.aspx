<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%--ESTE PROYECTO 'WebApplication1' ES EL EJEMPLO 5.0--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" action="WebForm2.aspx" method="post">
    <div>
        Nombre: <input name="txtNombre" type="text" /><br />
        Apellido: <input name="txtApellido" type="text" /><br />
        <input id="Submit1" type="submit" value="submit" /> 
    </div>
    </form>
</body>
</html>
