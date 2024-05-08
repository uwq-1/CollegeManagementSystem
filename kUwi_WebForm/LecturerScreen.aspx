<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/KIWA.Master" CodeBehind="LecturerScreen.aspx.cs" Inherits="kUwi_WebForm.LecturerScreen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <asp:Panel ID="ProfilePanel" runat="server">
        <asp:Label ID="ProfileNameLabel" runat="server" Text="Profile Name"></asp:Label>
        <asp:Label ID="EmailAddressLoginLabel" runat="server" Text="Email Address"></asp:Label>
        <asp:Label ID="LogoutLabel" runat="server" Text="Logout"></asp:Label>
        <asp:Label ID="ForgetPasswordLabel" runat="server" Text="Forget Password"></asp:Label>
    </asp:Panel>
<asp:Panel ID="LecturerHomeScreen" runat="server">
    <asp:Label ID="HomeScreen" runat="server" Text="Welcome!">
        <asp:Menu ID="LecturerNavigationMenu" 
            disappearafter="2000"
            staticdisplaylevels="1"
            orientation="Vertical"
            runat="server">
            <Items>
                <asp:MenuItem NavigateUrl ="~/HomeScreen.Master"
                    text="Home"
                    tooltip="Home" />
                <asp:MenuItem Selectable="true"
                    text="Class"
                    tooltip="Classes"/>
                    <asp:MenuItem Selectable="true"
                        text="Schedule"
                        tooltip="Class Schedule"/>
                        <asp:MenuItem Selectable="true"
                            text="Appointments"
                            tooltip="Appointment Book"/>
                            <asp:MenuItem Selectable="true"
                                text="Register"
                                tooltip="Student Attendance" />


            </Items>
        </asp:Menu>
    </asp:Label>


</asp:Panel>
</asp:Content>
