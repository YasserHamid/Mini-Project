<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="MGBooking.aspx.vb" Inherits="MiniProject.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="385px">
        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
        <DayStyle BackColor="#CCCCCC" />
        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
        <OtherMonthDayStyle ForeColor="#999999" />
        
        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
        <TodayDayStyle BackColor="#999999" ForeColor="White" />

        
    </asp:Calendar>
    <br/><br/>

    <asp:DropDownList runat="server" id="ddl" Height="16px" Width="167px" AutoPostBack="true" ></asp:DropDownList>
    <asp:DropDownList ID="ddl2" runat="server" Height="16px" style="margin-left: 42px" Width="170px" AutoPostBack="true"></asp:DropDownList>
    <br/><br/>
    <br/><br/>
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList runat="server" id="ddv" AutoPostBack="true" ></asp:DropDownList>
    <asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 132px" Width="161px"> </asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="" Height="23px"></asp:Label>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Create a Match" Width="377px" />
</asp:Content>
