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
            AppendDataBoundItems="true"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"            
            Height="16px"
            Width="224px">
            <asp:ListItem Text="Selecciona un cliente" Value="" />
        </asp:DropDownList>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
            DataSourceMode="DataSet"            
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="select CustomerID, (CustomerID + ' - ' + CompanyName) as formattedCustomer from Customers">        
        </asp:SqlDataSource>

        <%if (IsPostBack)
            { %>

        <asp:DropDownList ID="DropDownList2" runat="server"
            DataSourceID="SqlDataSource2"
            DataTextField="formattedEmployee"
            DataValueField="EmployeeID"
            AutoPostBack="true"
            AppendDataBoundItems="true"
            OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
            Height="16px"
            Width="224px">            
        </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server"
            DataSourceMode="DataSet"
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="select distinct Employees.Title, Employees.EmployeeID, Employees.FirstName, Employees.LastName, (Employees.FirstName + ' ' + Employees.LastName) as formattedEmployee from Employees inner join Orders on Employees.EmployeeID = Orders.EmployeeID inner join Customers on Orders.CustomerID = Customers.CustomerID where Customers.CustomerID = @customerId">
            <SelectParameters>
                <asp:ControlParameter
                    Name="customerId"
                    ControlID="DropDownList1"
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlDataSource3" runat="server"
            DataSourceMode="DataReader"
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            selectCommand="select Title, EmployeeId, FirstName, LastName from Employees where EmployeeID=@empleadoId">
            <SelectParameters>
                <asp:ControlParameter
                    Name="empleadoId"
                    ControlID="DropDownList2"
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>

        <br />

        <div>
            <asp:Label ID="Label1" runat="server" Text="Número de empleado: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="Apellido: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Cargo: "></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>

        <%} %>

    </div>
    </form>
</body>
</html>
