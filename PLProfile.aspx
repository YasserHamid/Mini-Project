<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PLProfile.aspx.vb" Inherits="MiniProject.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label class="label-success" ID="Label1" runat="server" Text="Welcome to your profile, "></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>

    <asp:Button ID="Button1" runat="server" Text="Edit your profile details" Width="195px" />
    <br/>
    <asp:Button ID="Button2" runat="server" class="btn-danger" Text="Delete your profile?" />
    <br />
    </asp:Content>
