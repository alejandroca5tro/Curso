<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise5_0_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Add Product</h1>
    <form id="form1" runat="server" action="WebForm2.aspx" method="post">
    <div>
     <fieldset>            
            <div>
                <label for="name">Name</label>
                <asp:TextBox ID="name2" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="category">Category</label>           
                <asp:DropDownList
                    ID="category"
                    name="category"
                    AutoPostBack="true"
                    runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem Text="Beverages" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Condiments" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Confections" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Dairy Products" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Grains/Cereals" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Meat/Poultry" Value="5"></asp:ListItem>
                    <asp:ListItem Text="Produce" Value="6"></asp:ListItem>
                    <asp:ListItem Text="Seafood" Value="7"></asp:ListItem>
      <%--              <asp:HiddenField id="hiddenfield" runat="server"></asp:HiddenField>--%>
                </asp:DropDownList>
            </div>
            <div>
                <label for="supplier">Supplier</label>
                <asp:DropDownList
                    ID="supplier"
                    name="supplier"
                    AutoPostBack="true"
                    runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem Text="Exotic Liquids" Value="0"></asp:ListItem>
                    <asp:ListItem Text="New Orleans Cajun Delights" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Grandma Kelly's Homestead" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Tokyo Traders" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Cooperativa de Quesos 'Las Cabras'" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Mayumi's" Value="5"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="unitPrice">Unit Price</label>
                <input type="text" id="unitPrice" name="unitPrice" />
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
