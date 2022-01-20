<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="GuessNumWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

    <div>
        <% this.Message = "Hello World"; %>
    </div>

    <p><% =this.Message %></p>

    <div>
        <table border="1">
            <% for (counter = 0; counter < RowCount; counter++)
                {%>
                    <tr><td>The count is: <% =counter %></td></tr>
                <%} %>
           
        </table>

        <asp:Button id="btnPushMe" runat="server" OnClick="btnPushMe_Click" />
    </div>

</asp:Content>
