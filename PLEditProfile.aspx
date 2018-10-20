<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PLEditProfile.aspx.vb" Inherits="MiniProject.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 66px" Width="194px"></asp:TextBox>
    <br />
     <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 37px" Width="195px"></asp:TextBox>
    <br />
     <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 44px" Width="195px"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update Details" Width="314px" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label4" runat="server" class="label-danger" Text=""></asp:Label>
</asp:Content>
