<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="MGResults.aspx.vb" Inherits="MiniProject.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DropDownList ID="ddv" runat="server" AutoPostBack="true">
    </asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Submit" />

    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br/>
    <br />
    
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
      <br/>
    <br />
    <asp:DropDownList ID="ddl" runat="server"></asp:DropDownList>
    <asp:Button ID="Button2" runat="server" Text="Generate from ID" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:TextBox ID="TextBox1" text="" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <asp:TextBox ID="TextBox2" text="" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" Text="Submit Result" />
    </asp:Content>
