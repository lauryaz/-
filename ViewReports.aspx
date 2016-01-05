<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewReports.aspx.cs" Inherits="WebApplication2.ViewReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/NEW.css" rel="stylesheet" />

    <div class="container">
        <h2><span class="glyphicon glyphicon-list-alt"></span>&nbsp&nbsp Reports </h2>

        <table class="table text-center">
            <tr class="text-center">
                <th class="text-center"><span class="glyphicon glyphicon-file"></span>&nbsp Report </th>
                <th class="text-center"><span class="glyphicon glyphicon-folder-open"></span>&nbsp Report type </th>
                <th class="text-center"><span class="glyphicon glyphicon-calendar"></span>&nbsp Date </th>
                <th class="text-center"><span class="glyphicon glyphicon-user"></span>&nbsp Director name </th>
                <th class="text-center"><span class="glyphicon glyphicon-th"></span>&nbsp Actions </th>
            </tr>

               
              
            <script src="/Scripts/deleteScripts.js"></script> 
        </table>

    </div>

</asp:Content>
