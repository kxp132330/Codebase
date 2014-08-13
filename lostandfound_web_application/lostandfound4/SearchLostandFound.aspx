<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchLostandFound.aspx.cs" Inherits="lostandfound4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
  <fieldset>
   <legend>SearchItem Lost/Found</legend>
      <table>
       <tr>
          <td>
          <asp:Label ID="Type" runat="server">Type </asp:Label>
          </td>
          <td>
         <asp:DropDownList ID="ddltype" runat="server">
             <asp:ListItem Value=-1>--Select type--</asp:ListItem>
               <asp:ListItem Value="lost">Lost</asp:ListItem>
               <asp:ListItem Value="Found">Found</asp:ListItem>
             </asp:DropDownList>
          </td>
      </tr>
          <tr><td><br/></td></tr>
   <tr>
       <td><asp:Label ID="Date" runat="server">Date</asp:Label></td>
       <td><asp:TextBox ID="txtdatepicker" runat="server"></asp:TextBox></td>
   </tr>
          <tr><td><br/></td></tr>
            <tr>
       <td><asp:Label ID="lblcategory" runat="server">Category</asp:Label></td>
       <td>
           <asp:DropDownList ID="ddlcategory" runat="server">
               <asp:ListItem Value=-1>--select category--</asp:ListItem>
               <asp:ListItem Value=1>Electronics</asp:ListItem>
               <asp:ListItem Value=2>Clothings</asp:ListItem>
               <asp:ListItem Value=3>book &amp; Notes</asp:ListItem>
               <asp:ListItem Value=4>monetary items</asp:ListItem>
               <asp:ListItem Value=5>other</asp:ListItem>
           </asp:DropDownList></td>
   </tr>
          <tr><td><br/></td></tr>
            <tr>
       <td><asp:Label ID="lbllocation" runat="server">Location</asp:Label></td>
       <td>
           <asp:DropDownList ID="ddllocation" runat="server">
               <asp:ListItem Value=-1>--select location--</asp:ListItem>
               <asp:ListItem Value=1>Erik jonsson</asp:ListItem>
               <asp:ListItem Value=2>Mcdermott Library</asp:ListItem>
               <asp:ListItem Value=3>JSOM</asp:ListItem>
               <asp:ListItem Value=4>Activity Center</asp:ListItem>
               <asp:ListItem Value=5>EdithDonell</asp:ListItem>
               <asp:ListItem Value=6>other</asp:ListItem>
           </asp:DropDownList></td>
   </tr>
          <tr><td><br/></td></tr>
    <tr>
       <td><asp:Label ID="lblkeyword" runat="server">Keyword</asp:Label></td>
       <td><asp:TextBox ID="txtkeyword" runat="server"></asp:TextBox></td>
   </tr>
          <tr><td><br/></td></tr>
<tr>
  <td>
   <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>
  </td>
</tr>
      </table>
  </fieldset>
      <br />
      <br />

      <asp:GridView ID="GridView1" runat="server" class="table table-striped table-hover ">
      </asp:GridView>
      
  </div>
      </ContentTemplate>
  </asp:UpdatePanel>


</asp:Content>
