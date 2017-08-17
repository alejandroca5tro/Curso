<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise01_5_2.WebForm1" %>

<!DOCTYPE html>

<script runat="server" type="text/javascript>
    private void serverClick(object sender, EventArgs e)
    {
        decimal result;
        result = Convert.

        res.InnerHtml = result.ToStrin();
    }

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input runat="server" id="Text1" type="text" />
        <br />
        <input runat="server" id="Text2" type="text" />
        <br />
        <input runat="server" id="Text3" type="text" />
        <br />
        <input runat="server" id="Button1" type="button" value="button" onserverclick="serverClick" />
        <br />
        <span runat="server" id="res"></span>
    </div>
    </form>
</body>
</html>
