<%@ Page Title="My Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="WebApplication2.Account.Account" %>

    <asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %></h2>

    <div class="row">
        <div class="col-md-8">
                <div class="form-horizontal">
                    <%if(director != null)
                     {  %>
                            <h4>Welcome <%=director.IdNumber%> </h4>
                    <%}%>
                    </div>
                </div>
        </div>
</asp:Content>
