<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/KIWA.Master" CodeBehind="Login_RegistrationScreen.aspx.cs" Inherits="kUwi_WebForm.Login_RegistrationScreen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Login" runat="server">
        <asp:Label ID="LoginLabel" runat="server" Text="LOGIN"></asp:Label><br />
        <asp:Label ID="UsernameLabel" runat="server" Text="Username: "></asp:Label> <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox><br /><br /><br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password: "></asp:Label><asp:TextBox ID="PasswordTextBox" TextMode ="Password" runat="server"></asp:TextBox><br /><br />
        <asp:LinkButton ID="RegistrationLinkButton" onclick="RegistrationLinkButton_Click" runat="server">Sign Up </asp:LinkButton>



    </asp:Panel>
    <asp:Panel ID="Registration" runat="server"></asp:Panel>
</asp:Content>

