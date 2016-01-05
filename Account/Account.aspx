<%@ Page Title="My Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="WebApplication2.Account.Account" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <link href="../Content/NEW.css" rel="stylesheet" />
    <h2><%: Title %></h2>


    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal">
                <%if (director != null)
                    {  %>
                <h4>Welcome <%=director.IdNumber%> </h4>
                <%}%>

                <asp:Panel runat="server" ID="PanelDepartmentDirector">

                   <!-- tout ce que je veux quil y est dans la page du departmentdirector-->

                </asp:Panel>


                <asp:Panel runat="server" ID="PanelTeamDirector">

                    <!-- tout ce que je veux quil y est dans la page du teamdirector-->

                </asp:Panel>

            </div>
        </div>


    </div>

</asp:Content>
