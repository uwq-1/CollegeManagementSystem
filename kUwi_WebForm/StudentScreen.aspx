<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/HomeScreen.master" CodeBehind="StudentScreen.aspx.cs" Inherits="kUwi_WebForm.StudentScreen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
     <asp:Panel ID="ProfilePanel" runat="server">
     <asp:Label ID="ProfileNameLabel" runat="server" Text="Profile Name"></asp:Label>
     <asp:Label ID="EmailAddressLoginLabel" runat="server" Text="Email Address"></asp:Label>
     <asp:Label ID="LogoutLabel" runat="server" Text="Logout"></asp:Label>
     <asp:Label ID="ForgetPasswordLabel" runat="server" Text="Forget Password"></asp:Label>
 </asp:Panel>
<asp:Panel ID="StudentHomeScreen" runat="server">
    <asp:Label ID="HomeScreen" runat="server" Text="Welcome!">
        <asp:Menu ID="StudentNavigationMenu" 
            disappearafter="2000"
            staticdisplaylevels="1"
            orientation="Vertical"
            runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/HomeScreen.Master"
                    text ="Home"
                    tooltip="Home"/>
                    <asp:MenuItem Selectable="true"
                        text="Program"
                        tooltip="Program">
                        <asp:MenuItem Selectable="true"
                            text="My Courses"
                            tooltip="My Courses" />
                        </asp:MenuItem>
                        <asp:MenuItem Selectable ="true"
                            text="Gradebook"
                            tooltip="Gradebook">
                           <asp:MenuItem Selectable="true"
                               text="Course Name"
                               tooltip="Course Name"/>
                               <asp:MenuItem Selectable="True"
                                   text="Module 1"
                                   tooltip="Module 1"/>
                                   <asp:MenuItem Selectable ="true"
                                       text="Module 2"
                                       tooltip="Module 2"/>
                                   <asp:MenuItem Selectable ="true"
                                       text="Module 3"
                                       tooltip="Module 3"/>
                            </asp:MenuItem>
                            <asp:MenuItem Selectable="true"
                                text="Account"
                                tooltip="Account">
                                </asp:MenuItem>
            </Items>
        </asp:Menu>
      </asp:Label>


</asp:Panel>
</asp:Content>


