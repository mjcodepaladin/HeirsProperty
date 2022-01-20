<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GuessNumSetupPage.aspx.cs" Inherits="GuessNumWeb.GuessNumSetupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <%=this.WelcomeMessage %>
    </div>
    <div>
        Get ready to play 4 rounds!
    </div>
    <div>
        <%=this.WelcomeInstruction %>
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
