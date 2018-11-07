<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="MGReports.aspx.vb" Inherits="MiniProject.WebForm16" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    Result History<br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>


    

    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label2" runat="server" Text="Bookings This Year"></asp:Label>
    <br />
    <asp:Chart ID="Chart1" runat="server">
        <Series>
            <asp:Series Name="Series1"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <br />
    <br />
</asp:Content>
