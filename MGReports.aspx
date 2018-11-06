<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="MGReports.aspx.vb" Inherits="MiniProject.WebForm16" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Matches this Year"></asp:Label>
    <br />
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="471px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1409px">
        <LocalReport ReportPath="bList.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>


    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="MiniProject.myDBDataSetAllTableAdapters._1v1BookingTableAdapter"></asp:ObjectDataSource>


    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label2" runat="server" Text="Goal Trend"></asp:Label>
    <br />
      <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" style="margin-bottom: 0px" Width="2535px">
        <series>
            <asp:Series ChartType="Spline" Name="Series1" XValueMember="Date" YValueMembers="Goals" YValuesPerPoint="2">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </chartareas>
    </asp:Chart>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myCS %>" SelectCommand="SELECT Date, Player1Score + Player2Score AS Goals FROM [1v1Result]"></asp:SqlDataSource>
    <br />
    <br />
</asp:Content>
