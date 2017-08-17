<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="Label1" runat="server" Text="Credit Card Information"></asp:Label>
        <br />

        <asp:Panel ID="Panel1" runat="server" BackColor="WhiteSmoke">
            <asp:Label ID="Label2" runat="server" Text="Card Type:"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Text="MasterCard"></asp:ListItem>
                <asp:ListItem Text="Visa"></asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>   
             
        <asp:Label ID="Label3" runat="server" Text="Card Number:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />

        <asp:Button ID="Button1" runat="server" Text="Validar" />

        <asp:RegularExpressionValidator
            ID="RegularExpressionValidator1"
            ControlToValidate="TextBox1"
            Text="?"
            runat="server"
            ValidationExpression="^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$"
            ErrorMessage="No es un formato de tarjeta de crédito">
        </asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator1"
            ControlToValidate="RadioButtonList1"
            Text="?"
            runat="server"
            ErrorMessage="Debes seleccionar un tipo de tarjeta">
        </asp:RequiredFieldValidator>

        <asp:ValidationSummary
            ID="ValidationSummary1"
            DisplayMode="BulletList"
            ShowSummary="true"
            ShowMessageBox="false"
            HeaderText="Errores producidos"
            BackColor="Yellow"
            runat="server" />
    </div>
    </form>
</body>
</html>
