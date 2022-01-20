<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlayerGuessNumSetupaspx.aspx.cs" Inherits="GuessNumWeb.PlayerGuessNumSetupaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        Welcome to Player Guesses Number!
    </div>
    <div>
        Get ready to play 4 rounds!
    </div>
    <div>
        Enter a range for the computer to choose a secret number.
    </div>
    <div>
        Please enter a lower and upper number:
    </div>

    <div>
          
         <table style="width:100%">
          <tr>
            <td> Lower Number: <asp:TextBox ID="txtLowerNum" runat="server" Width="30"></asp:TextBox></td>
          </tr>
          <tr>
            <td> Upper Number: <asp:TextBox ID="txtUpperNum" runat="server" Width="30"></asp:TextBox></td>
          </tr>
         </table>
    </div>

    <asp:Button ID="btnSetup" runat="server" Text="Enter" OnClick="btnSetup_Click" />


    <div runat="server" id="diErrorMessage" hidden="hidden">
        <%=this.diErrorMessage %>
    </div>
</asp:Content>
