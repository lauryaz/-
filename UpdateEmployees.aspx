<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateEmployees.aspx.cs" Inherits="WebApplication2.UpdateEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="Content/NEW.css" rel="stylesheet" />

    <h2 class="Header"><span class="glyphicon glyphicon-user"></span>&nbsp Update Employees</h2>

    <div class="paragraph1">
        <form class="form-inline">
            <div class="form-group">

                <label for="exampleInputName2">Id Number </label>
                <input type="text" class="form-control" id="exampleInputName2" placeholder="Id Number">
            </div>

            <button type="button" class="btn btn-primary">Update</button>
            <button type="button" class="btn btn-danger">Delete</button>

        </form>
    </div>











</asp:Content>
