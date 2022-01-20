<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuessResponsePage.aspx.cs" Inherits="GuessNumWeb.GuessResponsePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td style="height: 18px"> Your guess was <% %></td><td style="height: 18px"> </td>
        </tr>
        <tr>
            <td> Number of guesses <% %></td><td> </td>
        </tr>

        <tr>
             <td> <asp:Button id="btnGuessAgain" Text ="Guess Again" runat ="server" Height="31px" Width="106px"/> </td><td> <asp:Button id="btnPlayAgain" Text = "Play Again" runat ="server" Height="21px" Width="145px"/></td>
        </tr>
    </table>


</asp:Content>
