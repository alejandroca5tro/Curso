<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise12_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server">

        </asp:GridView>

        <asp:SqlDataSource
            ID="c"
            runat="server">
        </asp:SqlDataSource>

        <asp:SqlDataSource
            ID="Orders"
            SelectCommand="select OrderID, CustomerID, EmployeeID, Freight, ShipName, ShipAddress from Orders where CustomerID = @CustomerID"            
            UpdateCommand="update Orders set Freight = @Freight, ShipName = @ShipName, ShipAddress = @ShipAddress from Orders where CustomerID = @CustomerID"
            OnInserting=""
            UpdateCommand
            runat="server">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="CustomerID" PropertyName="SelectedValue" Type="String"/>
            </SelectParameters>

        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
