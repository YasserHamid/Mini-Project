<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="LoginMain.aspx.vb" Inherits="MiniProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="LOGIN" Font-Bold="True"></asp:Label>
    
      <table style="width:100%;">
                   
           <tr>
               <td style="width: 158px">User Name:</td>
               <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
               
           </tr>
           
           <tr>
               <td style="width: 158px">Password:</td>
               <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
           </tr>

           <tr>

               <td>
                   <asp:Button ID="Button1" runat="server" Text="LoginPlayer" Width="159px" />                
               </td>
               <td><asp:Button ID="Button2" runat="server" Text="LoginManager" Width="125px" /></td>
           </tr>

       </table>
        
</asp:Content>
