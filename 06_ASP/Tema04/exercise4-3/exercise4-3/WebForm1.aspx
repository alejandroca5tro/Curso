<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise4_3.WebForm1" %>

<!DOCTYPE html>

<script type="text/javascript">
    function validateLength(objectSource, args) {
        args.IsValid = (args.Value.length >= 4);
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    <div>

        <%--Nombre de usuario--%>
        <asp:Label ID="Label1" runat="server" Text="Nombre Usuario:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator1"
            ControlToValidate="TextBox1"
            runat="server"
            Text="*"
            ErrorMessage="Debes introducir un nombre de usuario">
        </asp:RequiredFieldValidator>
        <br />

        <%--Edad--%>
        <asp:Label ID="Label2" runat="server" Text="Edad:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator2"
            ControlToValidate="TextBox2"
            runat="server"
            Text="*"
            ErrorMessage="Debes introducir una contraseña">
        </asp:RequiredFieldValidator>
        <asp:RangeValidator
            ID="RangeValidator1"
            ControlToValidate="TextBox2"
            MinimumValue="18"
            MaximumValue="50"
            runat="server"
            Text="*"
            ErrorMessage="La edad debe estar comprendida entre 18 y 50">
        </asp:RangeValidator>        
        <br />

        <%--Contraseña--%>
        <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator3"
            ControlToValidate="TextBox3"
            runat="server"
            Text="*"
            ErrorMessage="Debes introducir una contraseña">
        </asp:RequiredFieldValidator>
        <asp:CustomValidator
            ID="CustomValidator1"   
            ClientValidationFunction="validateLength"
            ControlToValidate="TextBox3"
            runat="server"
            Text="*"
            ErrorMessage="La contraseña debe contener 4 carácteres o más">
        </asp:CustomValidator>        
        <br />        

        <%--Confirmar contraseña--%>
        <asp:Label ID="Label4" runat="server" Text="Confirmar Password:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator
            ID="RequiredFieldValidator4"
            ControlToValidate="TextBox4"
            runat="server"
            Text="*"
            ErrorMessage="Debes introducir de nuevo la contraseña">
        </asp:RequiredFieldValidator>        
        <asp:CompareValidator
            ID="CompareValidator1"
            ControlToValidate="TextBox4"
            ControlToCompare="TextBox3"
            runat="server"
            Text="*"
            ErrorMessage="Ambas contraseñas deben coincidir">
        </asp:CompareValidator>
        <br />
        <br />
      

        <asp:Button ID="Button1" runat="server" Text="Envío" />   
        <br />
        <br />

        <asp:ValidationSummary
            ID="ValidationSummary1"         
            DisplayMode="BulletList"
            ShowSummary="true"
            HeaderText="Errores producidos"
            BackColor="WhiteSmoke"    
            runat="server" />

    </div>
    </form>
</body>
</html>
