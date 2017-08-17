<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="exercise06_1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cuerpo" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Apellido: "></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    <hr />
    <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClientClick="this.form.reset();return false;"/>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
