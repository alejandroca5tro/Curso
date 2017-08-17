<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise09_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:DropDownList ID="DropDownList1" runat="server"
            DataSourceID="SqlDataSource1"
            DataTextField="formattedCustomer"
            DataValueField="CustomerID"
            AutoPostBack="true"
            AppendDataBoundItems="true">
            <asp:ListItem Text="Selecciona un cliente" Value="" />
        </asp:DropDownList>

        <asp:DropDownList ID="DropDownList2" runat="server"
            DataSourceID="SqlDataSource2"
            DataTextField="formattedEmployee">
        </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
            DataSourceMode="DataReader"            
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="select CustomerID, (CustomerID + ' - ' + CompanyName) as formattedCustomer from Customers">        
        </asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server"
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="select (Employees.FirstName + ' ' + Employees.LastName) as formattedEmployee from Employees inner join Orders on Employees.EmployeeID = Orders.EmployeeID inner join Customers on Orders.CustomerID = Customers.CustomerID where Customers.CustomerID = @customerId">
            <SelectParameters>
                <asp:ControlParameter
                    Name="customerId"
                    ControlID="DropDownList1"
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>

    </div>
    </form>
</body>
</html>
