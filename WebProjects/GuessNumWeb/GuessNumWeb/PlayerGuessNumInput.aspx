<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlayerGuessNumInput.aspx.cs" Inherits="GuessNumWeb.PlayerGuessNumInput" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        Welcome to Player Guesses Number!
    </div>
    <div>
          
         <table style="width:100%">
          <tr>
            <td>I am thinking of a number between <%=this.LowerNum%> and <%=this.UpperNum%>. </td>
          </tr>
         </table>
    </div>
   
    <div>
        Please enter your number guess:
    </div>
    <asp:TextBox ID="txtBoxUserNum" runat="server" Width="30"></asp:TextBox>


    <asp:Button ID="btnUserGuess" runat="server" Text="Guess" OnClick="btnUserGuess_Click" />



</asp:Content>
