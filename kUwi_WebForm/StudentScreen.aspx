<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/KIWA.Master" CodeBehind="StudentScreen.aspx.cs" Inherits="kUwi_WebForm.StudentScreen" %>

<!-- Latona You need to close the <asp:Content> tag with </asp:Content> to get it to stop complaining about content-->
<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
<asp:Panel ID="StudentScreen" runat="server">
    <asp:Label ID="HomeScreen" runat="server" Text=" Home Screen">
        <asp:BulletedList ID="StudentBulletedList" runat="server">
            BulletStyle= "Disc"
        </asp:BulletedList>
    </asp:Label>


</asp:Panel>
</asp:Content>


