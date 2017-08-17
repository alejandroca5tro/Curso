
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="example01.WebForm1" %>

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
            runat="server"
            DataSourceID="SqlDataSource1"
            EnableSortingAndPagingCallbacks="True"
            AllowSorting="True"
            AllowPaging="True"    
            PageSize="15"        
            EmptyDataText="No hay datos"
            AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
            <PagerSettings
                Mode="NumericFirstLast"
                FirstPageText="First"
                LastPageText="Last"
                PageButtonCount="5"
                Position="Bottom"/>
            <PagerStyle
                BackColor="LightBlue"
                Height="30px"
                Width="30px"
                VerticalAlign="Bottom"
                HorizontalAlign="Center" />
            <Columns>
                <asp:BoundField
                    HeaderText="Código de Producto" 
                    NullDisplayText="Sin valor"
                    SortExpression="ProductID"
                    DataField="ProductID"/>

                <asp:BoundField
                    HeaderText="Nombre de Producto" 
                    NullDisplayText="Sin valor"
                    SortExpression="ProductName"
                    DataField="ProductName"/>

                <asp:BoundField
                    HeaderText="Cantidad por unidad" 
                    NullDisplayText="Sin valor"
                    SortExpression="QuantityPerUnit"
                    DataField="QuantityPerUnit"/>

                <asp:HyperLinkField
                    DataTextField="UnitPrice"
                    DataTextFormatString="{0:c}"
                    DataNavigateUrlFields="ProductID"
                    DataNavigateUrlFormatString="WebForm3.aspx?ProductId={0}"
                    HeaderText="Precio Unitario"
                    Target="_blank" />

                <asp:CheckBoxField
                    DataField="Discontinued"
                    HeaderText="Descuento?" />                                    

            </Columns>
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />      
        </asp:GridView>

        <asp:SqlDataSource
            ID="SqlDataSource1"
            runat="server"
            ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="select * from Products"
            DataSourceMode="DataSet"            
            ></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
