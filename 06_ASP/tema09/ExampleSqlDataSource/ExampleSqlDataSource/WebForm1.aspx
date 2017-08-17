<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExampleSqlDataSource.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server">
        </asp:TextBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
            DataSourceMode="DataSet"            
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="select FirstName, LastName, Title from Employees where EmployeeId = @codigoEmpleado"
            UpdateCommand="Update Employees set FirstName=@FirstName, LastName=@LastName, Title=@Title where EmployeeId = @codigoEmpleado">
            <SelectParameters>
                <asp:ControlParameter
                    Name="codigoEmpleado"
                    ControlID="DropDownList1"
                    PropertyName="SelectedValue" />
                <asp:ControlParameter
                    Name="FirstName"
                    ControlID="TextBox1"
                    PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server"
            DataSourceID="SqlDataSource1">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
