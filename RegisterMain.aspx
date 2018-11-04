<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RegisterMain.aspx.vb" Inherits="MiniProject.WebForm2" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ContentStuff">


        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; REGISTER PLAYER</p>

       
       <table  style="width:100%;">
           <tr>
               <td style="width: 233px">Name:</td>
               <td><asp:TextBox ID="TextBox1" runat="server" Width="203px"></asp:TextBox></td>
               
           </tr>
           
           <tr>
               <td style="width: 233px">User Name:</td>
               <td><asp:TextBox ID="TextBox2" runat="server" Width="203px"></asp:TextBox></td>
               
           </tr>
           
           <tr>
               <td style="width: 233px">Password:</td>
               <td><asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox></td>
           </tr>

           <tr>

               <td style="width: 233px">
                   <asp:Button ID="Button1" runat="server" Text="Register" Width="237px" />
               </td>
           </tr>

       </table>



   </div>

   <p>









   </p>
    
 
    
    <asp:HyperLink ID="HyperLink1" runat="server" href="RegisterManager.aspx" BackColor="Black" Font-Bold="True">wanto register as a MANAGER?</asp:HyperLink>
    


</asp:Content>
