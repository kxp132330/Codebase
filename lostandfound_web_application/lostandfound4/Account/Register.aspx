﻿<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="lostandfound4.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-md-2 control-label">First Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                    CssClass="text-danger" ErrorMessage="The First Name is required." />
                </div>
                    </div>

                      <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">Last Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="LastName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                    CssClass="text-danger" ErrorMessage="The Last Name is required." />
                </div>
                          </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="MobileNumber" CssClass="col-md-2 control-label">Mobile Number</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="MobileNumber" CssClass="form-control" />
                <asp:RegularExpressionValidator ControlToValidate="MobileNumber"  runat="server" ErrorMessage="Enter valid Phone number" 
     ValidationExpression = "^([0-9\(\)\/\+ \-]*)$"></asp:RegularExpressionValidator>
                </div>
                          </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Emailid" CssClass="col-md-2 control-label">Email ID</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Emailid" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Emailid"
                    CssClass="text-danger" ErrorMessage="The user name field is required." />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="Emailid" CssClass="text-danger" 
                     ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server" ErrorMessage="Not a Valid Email address"/>
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
