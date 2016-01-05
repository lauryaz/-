<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="WebApplication2.Account.AddEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="RegPanel" runat="server" DefaultButton="RegButton">
        <link href="../Content/NEW.css" rel="stylesheet" />

        <div class="container top-padding">
            <div class="col-md-5">

                <h2 style="color: white;"><span class="glyphicon glyphicon-plus-sign"></span>&nbsp Add Employees</h2>

                <div class="panel panel-default" style="opacity: 0.8; margin: 5%;">
                    <div class="panel-body">
                        <div style="margin-top: 5%;">
                            <ul class="list-unstyled form-group">


                                <li class="row">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-user" "></span>&nbsp First Name
                                        <asp:TextBox class="form-control" ID="FirstNameTextBox" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4">
                                        <br />
                                        <asp:Label class="errorMessage" ID="Label1" runat="server" Text=""></asp:Label>
                                    </div>
                                </li>

                                <li class="row">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-user" "></span>&nbsp Last Name
                            <asp:TextBox Class="form-control" ID="LastNameTextBox" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4">
                                        <br />
                                        <asp:Label class="errorMessage" ID="Label2" runat="server" Text=""></asp:Label>
                                    </div>
                                </li>


                                <li class="row">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-phone-alt" "></span>&nbsp Id Number
                            <asp:TextBox Class="form-control" ID="PhoneNumberTextBox" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4">
                                        <br />
                                        <asp:Label class="errorMessage" ID="Label4" runat="server" Text=""></asp:Label>
                                    </div>
                                </li>


                                <li class="row">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-asterisk" "></span>&nbsp Role
                            <asp:TextBox Class="form-control" ID="PasswordTextBox" runat="server" TextMode="password"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4">
                                        <br />
                                        <asp:Label class="errorMessage" ID="Label6" runat="server" Text=""></asp:Label>
                                    </div>
                                </li>

                                <li class="row">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-calendar" "></span>&nbsp Date Begin
                            <asp:TextBox Class="form-control" ID="TextBox1" runat="server" TextMode="password"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4">
                                        <br />
                                        <asp:Label class="errorMessage" ID="Label3" runat="server" Text=""></asp:Label>
                                    </div>
                                </li>


                            </ul>
                        </div>
                        <p>
                            <asp:Button class="btn btn-success" ID="RegButton" runat="server" OnClick="Button1_Click" Text="Confirm" />
                        </p>
                    </div>
                </div>
            </div>
        </div>

    </asp:Panel>
</asp:Content>
