<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PLDelete.aspx.vb" Inherits="MiniProject.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="Label1" class="label-danger" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 66" Width="119px"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" class="btn-danger" runat="server" Text="Delete" Width="193px" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
