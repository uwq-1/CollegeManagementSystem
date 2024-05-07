<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/KIWA.Master" CodeBehind="StudentScreen.aspx.cs" Inherits="kUwi_WebForm.StudentScreen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="StudentScreen" runat="server">
    <asp:Label ID="HomeScreen" runat="server" Text=" Home Screen">
        <asp:BulletedList ID="StudentBulletedList" runat="server">
            BulletStyle= "Disc"
        </asp:BulletedList>
    </asp:Label>


</asp:Panel>
</asp:Content>


