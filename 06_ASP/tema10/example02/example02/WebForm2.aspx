<%@ Page Language="C#" Theme="App_Themes" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="example02.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource
            ID="SqlDataSource1"
            SelectCommand="select top 5 ProductId, ProductName, UnitPrice from Products order by ProductName"
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            runat="server">
        </asp:SqlDataSource>
            <h2>Un GridView sin Skin</h2>

        <asp:GridView
            ID="GridView1"
            DataSourceID="SqlDataSource1"
            DataKeyNames="ProductID"
            AutoGenerateColumns="false"
            SkinID="Fun"            
            runat="server">
            <Columns>
                <asp:BoundField
                    ReadOnly="true"
                    HeaderText="ProductID"
                    DataField="ProductID"
                    SortExpression="ProductID" />
                <asp:BoundField
                    HeaderText="ProductName"
                    DataField="ProductName"
                    SortExpression="ProductName" />
                <asp:BoundField
                    HeaderText="UnitPrice"
                    DataField="UnitPrice"
                    SortExpression="UnitPrice" />
            </Columns>

        </asp:GridView>

            
   
    </div>
    </form>
</body>
</html>
