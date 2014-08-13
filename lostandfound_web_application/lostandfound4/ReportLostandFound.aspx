<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportLostandFound.aspx.cs" Inherits="lostandfound4.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
  <fieldset>
   <legend>Report Item Lost/Found</legend>
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
       <td><asp:Label ID="lbltitle" runat="server">Title</asp:Label></td>
       <td><asp:TextBox ID="txttitle" runat="server"></asp:TextBox></td>
   </tr>
          <tr><td><br/></td></tr>
           <tr>
       <td><asp:Label ID="lbldesc" runat="server">Desc</asp:Label></td>
       <td><asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine"></asp:TextBox></td>
   </tr>
          <tr><td><br/></td></tr>
    <tr>
       <td><asp:Label ID="lblprimary" runat="server">Primary Color</asp:Label></td>
       <td><asp:TextBox ID="txtprimary" runat="server"></asp:TextBox></td>
   </tr>
          <tr><td><br/></td></tr>
              <tr>
       <td><asp:Label ID="lblserialnumber" runat="server">SerialNumber </asp:Label></td>
       <td><asp:TextBox ID="txtserialnumber" runat="server"></asp:TextBox></td>
   </tr>
          <tr><td><br/></td></tr>
   <tr>
       <td>
           <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>
       </td>
       <td>
         <asp:Label ID="lblsucess" runat="server" Visible="false">message</asp:Label>
       </td>

   </tr>
      </table>
  </fieldset>
  </div>
      </ContentTemplate>
  </asp:UpdatePanel>

</asp:Content>
