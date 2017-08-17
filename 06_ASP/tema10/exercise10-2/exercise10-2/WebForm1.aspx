<%@ Page Language="C#" AutoEventWireup="true" Theme="App_Theme" CodeBehind="WebForm1.aspx.cs" Inherits="exercise10_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
        <asp:GridView
            ID="GridView1"
            AutoGenerateColumns="false"
            DataSourceID="SqlDataSource1"
            SkinID="Professional"
            OnRowCommand="GridView1_RowCommand"
            AutoGenerateEditButton="true"
            
            runat="server">

             <Columns>           
                <asp:ButtonField
                    HeaderText="SELECCIONAR"
                    ButtonType="Button"
                    Text="Select" 
                    CommandName="Select"/>           
                <asp:BoundField
                    HeaderText="EMPLOYEEID"
                    DataField="EmployeeID"
                    SortExpression="EmployeeID" />
                <asp:BoundField
                    HeaderText="LASTNAME"
                    DataField="LastName"
                    SortExpression="LastName" />
                <asp:BoundField
                    HeaderText="FISTNAME"
                    DataField="FirstName"
                    SortExpression="FirstName" />
                <asp:BoundField
                    HeaderText="TITLE"
                    DataField="Title"
                    SortExpression="Title" />
            </Columns>
        </asp:GridView>

        <asp:SqlDataSource
            ID="SqlDataSource1"
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="select * from Employees"
            UpdateCommand="update Employees set EmployeeID, LastName, FirstName, Title where EmployeeID = @EmployeeID"
            runat="server">
            <UpdateParameters>
                <asp:Parameter Type="Int32" Name="EmployeeID" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cargo: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />


    </div>
    </form>
</body>
</html>
