<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/KIWA.Master" CodeBehind="LecturerScreen.aspx.cs" Inherits="kUwi_WebForm.LecturerScreen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
<asp:Panel ID="LecturerScreen" runat="server">
    <asp:Label ID="HomeScreen" runat="server" Text=" Home Screen">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:BulletedList ID="StudentBulletedList" runat="server">
            BulletStyle= "Disc"
            DisplayMode="LinkButton"
            onClick="ItemsBulletedList_Click"
            runat="Server">
            <asp:ListItem Value="HomePage"> Home </asp:ListItem>
            <asp:ListItem Value="StudentGradebook"> Student Gradebook </asp:ListItem>
            <asp:ListItem Value="Account"> Account </asp:ListItem>
            <asp:ListItem Value="Schedule"> Schedule </asp:ListItem>
            <asp:ListItem Value="Registration"> Registration </asp:ListItem>

        </asp:BulletedList>
    </asp:Label>


</asp:Panel>
</asp:Content>
