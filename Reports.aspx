<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Reports.aspx.vb" Inherits="MiniProject.WebForm17" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>





<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>





<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    
    <div class ="top">
     <asp:Chart ID="Chart1" name="TotalPlayers"  runat="server">
        <Series>
            <asp:Series Name="Series1">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
   
  </div>

    </asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">
   
    
    
</asp:Content>
