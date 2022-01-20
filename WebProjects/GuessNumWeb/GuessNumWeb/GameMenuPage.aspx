<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameMenuPage.aspx.cs" Inherits="GuessNumWeb.GameMenuPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>Select the game you would like to play:</div>

    <asp:DropDownList ID ="ddlMenuChoices" runat="server">
        <asp:listitem Value="p" Text="(P)layer Guesses Number"/>
        <asp:listitem Value="c" Text="(C)omputer Guesses Number"/>
        <asp:listitem Value="v" Text="Computer (V)S Computer Number"/>
    </asp:DropDownList> 

    <div>
        <asp:Button ID="btnSelect" Text="Submit" runat="server" OnClick="btnSelect_Click"/>
    </div>
</asp:Content>
