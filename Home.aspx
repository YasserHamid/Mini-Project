<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Home.aspx.vb" Inherits="MiniProject.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="container" >
 <div id="myCarousel" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
      
   
   
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active">
        <div class="carousel-caption">
            <h1 style="font-family:Georgia, 'Times New Roman', Times, serif; color:gold;">Participate in Upcoming Competitions</h1>
            
       
      </div>
      <img src="/imgs/bgi2.png" />
        
       
    </div>

    <div class="item">
          <div class="carousel-caption">
        <h1 style="font-family:Georgia, 'Times New Roman', Times, serif; color:gold;">International Rules and Regulations</h1>
           
              </div>
      <img src="/imgs/bgi2.png" />
    </div>

     <div class="item">
          <div class="carousel-caption">
        <h1 style="font-family:Georgia, 'Times New Roman', Times, serif; color:gold;">Host a Competition</h1>
            
              </div>
      <img src="/imgs/bgi2.png" />
    </div>

    
  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
            </div> 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
