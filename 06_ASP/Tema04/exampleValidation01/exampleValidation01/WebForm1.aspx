<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exampleValidation01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Dime la edad:
        <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
        <asp:CompareValidator
            ID="ageValidator"
            runat="server"
            ControlToValidate="ageTextBox"
            ValueToCompare="18"
            Operator="GreaterThanEqual"
            Type="Integer"
            ErrorMessage="Debes ser mayor de 18">
        </asp:CompareValidator>
        <br />
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator
            ID="RegularExpressionValidator1"
            runat="server"
            ControlToValidate="txtEmail"
            ErrorMessage="No es una dirección válida"
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
        </asp:RegularExpressionValidator>
        <br />
        <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
        <asp:RangeValidator
            ID="RangeValidator1"
            runat="server"
            ControlToValidate="txtAltura"
            type="Integer"
            MinimumValue="165"
            MaximumValue="198"
            ErrorMessage="Fuera de rango">
        </asp:RangeValidator>
         <br />
        Introduce tu nombre:
        <asp:TextBox ID="TextBox1"
            runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator1"
            runat="server"
            ControlToValidate="txtNombre"
            ErrorMessage="RequiredFieldValidator">            
        </asp:RequiredFieldValidator>
    </div>
    </form>
</body>
</html>
