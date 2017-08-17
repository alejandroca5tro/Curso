<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exCustomValidator02.WebForm1" %>

<!DOCTYPE html>

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
            runat="server"
            ControlToValidate="TextBox1"
            OnServerValidate="CustomValidator1_ServerValidate"
            ErrorMessage="Debes introducir un número par">
        </asp:CustomValidator>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
