<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise5_0_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Add Product</h1>
    <form id="form1" runat="server" action="WebForm2.aspx">
    <div>
     <fieldset>            
            <div>
                <label for="name">Name</label>
                <input type="text" id="name" name="name" />
            </div>
            <div>
                <label for="category">Category</label>           
                <asp:DropDownList ID="category" name="category" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Beverages</asp:ListItem>
                    <asp:ListItem>Condiments</asp:ListItem>
                    <asp:ListItem>Confections</asp:ListItem>
                    <asp:ListItem>Dairy Products</asp:ListItem>
                    <asp:ListItem>Grains/Cereals</asp:ListItem>
                    <asp:ListItem>Meat/Poultry</asp:ListItem>
                    <asp:ListItem>Produce</asp:ListItem>
                    <asp:ListItem>Seafood</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="supplier">Supplier</label>
                <asp:DropDownList ID="supplier" name="supplier" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Exotic Liquids</asp:ListItem>
                    <asp:ListItem>New Orleans Cajun Delights</asp:ListItem>
                    <asp:ListItem>Grandma Kelly's Homestead</asp:ListItem>
                    <asp:ListItem>Tokyo Traders</asp:ListItem>
                    <asp:ListItem>Cooperativa de Quesos 'Las Cabras'</asp:ListItem>
                    <asp:ListItem>Mayumi's</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <label for="unitPrice">Unit Price</label>
                <input type="text" id="unitPrice" name="unitPrice" />
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
