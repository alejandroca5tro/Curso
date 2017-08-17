<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise09_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server" GridLines="Both">
            <HeaderStyle />
            <FooterStyle  />
            <HeaderTemplate>
                <table border="1">
                    <tr>
                        <th>CategoryID</th>
                        <th>CategoryName</th>                        
                    </tr>               
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td ><%# DataBinder.Eval(Container.DataItem,"CategoryID") %></td>
                    <td ><%# DataBinder.Eval(Container.DataItem,"CategoryName") %></td>                 
                </tr>
            </ItemTemplate>
        </asp:DataList>    
    </div>
    </form>
</body>
</html>
