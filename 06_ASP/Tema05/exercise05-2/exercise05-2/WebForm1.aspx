<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise05_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Alumno: "></asp:Label>
        <asp:TextBox ID="txtStudent" runat="server"></asp:TextBox>
        <hr />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label2" runat="server" Text="Matemáticas: "></asp:Label>
            <asp:TextBox ID="txtSubject1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Física: "></asp:Label>
            <asp:TextBox ID="txtSubject2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Tecnología Industrial: "></asp:Label>
            <asp:TextBox ID="txtSubject3" runat="server"></asp:TextBox>
            <br />
        </asp:Panel>
        <hr />
        <asp:Button ID="Button1" runat="server" Text="Calcular nota media" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
