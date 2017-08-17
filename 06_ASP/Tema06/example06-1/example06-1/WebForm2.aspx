<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="example06_1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenido" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Dato original: "></asp:Label>
    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="footer" runat="server">
    Fecha Actual:
    <asp:TextBox ID="txtFecha" runat="server" Text="<%DateTime.Now();%>"></asp:TextBox>
</asp:Content>