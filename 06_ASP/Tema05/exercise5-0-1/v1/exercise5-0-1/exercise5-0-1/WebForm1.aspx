<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise5_0_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" method="post" action="WebForm2.aspx">
    <div>
        <fieldset>
            <legend>Add Customers:</legend>
            <div>
                <label for="CompanyName">Company Name</label>
                <input type="text" id="CompanyName" name="CompanyName" />
            </div>
            <div>
                <label for="ContactName">Contact Name</label>
                <input type="text" id="ContactName" name="ContactName" />
            </div>
            <div>
                <label for="Employees">Employees</label>
                <input type="text" id="Employees" name="Employees" />
            </div>
            <div>
                <input type="submit" value="Enviar" />
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>
