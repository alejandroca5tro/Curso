<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exCustomValidation.WebForm1" %>

<!DOCTYPE html>

<script type="text/javascript">
    function ValidarLongitud(objectSource, args) {
        args.IsValid = (args.Value.length >= 8);   
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>        
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator
            ID="CustomValidator1"
            OnServerValidate="CustomValidator1_ServerValidate"
            ControlToValidate="TextBox1"
            runat="server"
            ErrorMessage="Al menos debe tener 8 carácteres (Validación desde servidor)">
        </asp:CustomValidator>
        <asp:CustomValidator
            ID="CustomValidator2"
            ControlToValidate="TextBox1"
            ClientValidationFunction="ValidarLongitud"
            runat="server"
            ErrorMessage="Al menos debe tener 4 carácteres (Validación desde cliente)">
        </asp:CustomValidator>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
