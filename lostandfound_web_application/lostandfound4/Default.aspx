<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lostandfound4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <br />
<div class="container-fluid">
      
      <div class="row row-offcanvas row-offcanvas-left">
        
         <div class="col-sm-3 col-md-2 sidebar-offcanvas" id="sidebar" role="navigation">
           
            
             <div class="panel panel-primary">
  <div class="panel-heading">
    <h3 class="panel-title">Panel primary</h3>
  </div>
  <div class="panel-body">
    <ul class="nav nav-sidebar">
              <li class="active"><a href="#">Lost and Found</a></li>
              <li><a href="#">Items Found</a></li>
              <li><a href="#">Items Lost </a></li>
              <li><a href="#"> Set Notification</a></li>
            </ul>
  </div>
</div>
          </div><!--/span-->
      </div>


</div>

</asp:Content>
