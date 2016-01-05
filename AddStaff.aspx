<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStaff.aspx.cs" Inherits="WebApplication2.AddStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/NEW.css" rel="stylesheet" />

    <div class="container top-padding">

        <div class="col-md-6">

            <h2 style="color: white"><span class="glyphicon glyphicon-asterisk" style="color: white"></span>&nbsp Add Staff</h2>
            <div class="panel panel-default" style="opacity: 0.8; margin: 5%;">
                <div class="panel-body">
                    <div style="margin-top: 6%;">
                        <ul class="list-unstyled form-group">


                            <li class="row">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-asterisk"></span>&nbsp Name project                
                                <asp:TextBox class="form-control" ID="FirstNameTextBox" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-4">
                                    <br />
                                    <asp:Label class="errorMessage" ID="Label1" runat="server" Text=""></asp:Label>
                                </div>
                            </li>

                            <li class="row">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-asterisk"></span>&nbsp Director
                           <div class="dropdown">
                               <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                                   Director
                                   <span class="caret"></span>
                               </button>
                               <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                                   <li><a href="#">Sarah Cohen</a></li>
                                   <li><a href="#">Laury Aziza</a></li>
                                   <li><a href="#">David Harel</a></li>
                               </ul>
                           </div>
                                </div>
                                <div class="col-md-4">
                                    <br />
                                    <asp:Label class="errorMessage" ID="Label2" runat="server" Text=""></asp:Label>
                                </div>
                            </li>


                            <li class="row">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-asterisk"></span>&nbsp Staff members
                             <div class="dropdown">

                                 <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                                     Employees
                                   <span class="caret"></span>

                                 </button>
                                 <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                                     <li><a href="#">Ory Levi</a></li>
                                     <li><a href="#">Tamar Benishay</a></li>
                                     <li><a href="#">Karin Levy</a></li>
                                     <li><a href="#">Elay Assan</a></li>
                                     <li><a href="#">Gabriel Ben</a></li>
                                     <li><a href="#">Guy Binyamini</a></li>
                                     <li><a href="#">Elia Mizrahi</a></li>
                                     <li><a href="#">Adam Cohen</a></li>
                                     <li><a href="#">Dan Levy</a></li>
                                     <li><a href="#">Elie Aziza</a></li>
                                 </ul>

                                 <asp:Label class="labeltext" ID="Label3" runat="server" Text=""></asp:Label>

                             </div>
                                    <textarea rows="10" cols="30"></textarea>
                                </div>
                                <div class="col-md-4">
                                    <br />
                                    <asp:Label class="errorMessage" ID="Label4" runat="server" Text=""></asp:Label>
                                </div>
                            </li>

                            <li class="row">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-asterisk"></span>&nbsp Problem Description                
                              <br />
                                    <textarea rows="4" cols="50"></textarea>

                                </div>
                                <div class="col-md-4">
                                    <br />
                                    <asp:Label class="errorMessage" ID="Label5" runat="server" Text=""></asp:Label>
                                </div>
                            </li>

                            <button type="button" class="btn btn-primary btn-lg" style="margin-left: 4px">ADD</button>


                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
