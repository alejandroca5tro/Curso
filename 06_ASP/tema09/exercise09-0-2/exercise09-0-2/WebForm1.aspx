<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise09_0_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="true">
            <asp:ListItem Value="1" Selected="True">Si</asp:ListItem>
            <asp:ListItem Value="0">No</asp:ListItem>
        </asp:RadioButtonList>
        <asp:DataList ID="DataList1" runat="server" GridLines="Both">
            <HeaderStyle BackColor="Yellow" />
            <FooterStyle BackColor="Wheat" />
            <HeaderTemplate>
                <table border="1">
                    <tr>
                        <th>ProductName</th>
                        <th>QuantityPerUnit</th>
                        <th>UnitPrice</th>
                        <th>UnitsInStock</th>                        
                    </tr>                
            </HeaderTemplate>
            <ItemStyle BackColor="Yellow" ForeColor="Violet" />
             <ItemTemplate>
                    <tr>
                        <td><%#DataBinder.Eval(Container.DataItem, "ProductName") %></td>
                        <td><%#DataBinder.Eval(Container.DataItem, "QuantityPerUnit") %></td>
                        <td><%#DataBinder.Eval(Container.DataItem, "UnitPrice") %></td>
                        <td><%#DataBinder.Eval(Container.DataItem, "UnitsInStock") %></td>
                    </tr>
            </ItemTemplate>
            <SeparatorTemplate>
                <tr>
                    <td colspan="4"><hr /></td>
                </tr>
            </SeparatorTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
