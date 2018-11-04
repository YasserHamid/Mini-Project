<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="MGReports.aspx.vb" Inherits="MiniProject.WebForm16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Bookings this Year"></asp:Label>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label2" runat="server" Text="Result History"></asp:Label>
    <asp:GridView ID="GridView2" runat="server"></asp:GridView>

</asp:Content>
