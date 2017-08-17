<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<script runat="server">
    private void MakeUpper(object sender, EventArgs e)
    {
        string buf = TheString.Value;
        TheResult.InnerHtml = buf.ToUpper();
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Make it upper</h1>
    <form id="form1" runat="server">
    <div>
        <input runat="server" id="TheString" type="text" />
        <input runat="server" id="button1" type="submit" onserverclick="MakeUpper" value="Proceed...." />

        <hr />

        <h3>Results:</h3>
        <span runat="server" id="TheResult"></span>
    </div>
    </form>
</body>
</html>