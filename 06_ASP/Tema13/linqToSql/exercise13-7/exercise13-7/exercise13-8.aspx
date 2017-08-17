<%@ Page Language="C#" enableEventValidation="false"  AutoEventWireup="true" CodeBehind="exercise13-8.aspx.cs" Inherits="exercise13_7.exercise13_8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1"
            OnRowDataBound="GridView1_RowDataBound"            
            runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand"></asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Unidades en Stock: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
