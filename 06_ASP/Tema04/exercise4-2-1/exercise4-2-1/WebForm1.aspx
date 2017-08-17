<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise4_2_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator
            ID="RangeValidator1"
            ControlToValidate="TextBox1"
            MinimumValue="1"
            Text="*"
            MaximumValue="10"
            Display="Static"
            Type="Integer"
            runat="server"
            ErrorMessage="Debes introducir un número entre el 1 y el 10">
        </asp:RangeValidator>
        <asp:ValidationSummary
            ID="ValidationSummary1"
            HeaderText="LISTA DE ERRORES"
            DisplayMode="BulletList"
            ShowSummary="true"
            ShowMessageBox="false"
            runat="server" />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
