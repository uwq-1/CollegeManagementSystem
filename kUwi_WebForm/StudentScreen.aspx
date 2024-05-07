<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/KIWA.Master" CodeBehind="StudentScreen.aspx.cs" Inherits="kUwi_WebForm.StudentScreen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
<asp:Panel ID="StudentHomeScreen" runat="server">
    <asp:Label ID="HomeScreen" runat="server" Text=" Home Screen">
        <asp:BulletedList ID="StudentBulletedList"
            BulletStyle= "Disc"
            DisplayMode="LinkButton"
            onClick="StudentBulletedList_Click"
            runat="server">
            <asp:ListItem Value="HomePage"> Home </asp:ListItem>
            <asp:ListItem Value="Gradebook"> Gradebook </asp:ListItem>
            <asp:ListItem Value="Account"> Account </asp:ListItem>
            <asp:ListItem Value="MyCourses"> My Courses </asp:ListItem>
        </asp:BulletedList>
    </asp:Label>


</asp:Panel>
</asp:Content>


