<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/KIWA.Master" CodeBehind="Login_RegistrationScreen.aspx.cs" Inherits="kUwi_WebForm.Login_RegistrationScreen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Login" runat="server">
        <asp:Label ID="LoginLabel" runat="server" Text="LOGIN"></asp:Label><br />
        <asp:Label ID="UsernameLabel" runat="server" Text="Username: "></asp:Label> <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox><br /><br /><br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password: "></asp:Label><asp:TextBox ID="PasswordTextBox" TextMode ="Password" runat="server"></asp:TextBox><br /><br />
        <asp:LinkButton ID="RegistrationLinkButton" OnClick="RegistrationLinkButton_Click" runat="server">Sign Up </asp:LinkButton>

        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick ="LoginButton_Click" />

    </asp:Panel>
    <asp:Panel ID="Registration" runat="server">
        <asp:RadioButtonList ID="Lecturer_StudentRadioButtonList" runat="server" OnSelectedIndexChanged="Lecturer_StudentRadioButtonList_SelectedIndexChanged">
            <asp:ListItem>Lecturer </asp:ListItem>
            <asp:ListItem>Student </asp:ListItem>
            </asp:RadioButtonList><br /><br />
    <asp:Panel ID="StudentRegistrationPanel" runat="server">
        <asp:Label ID="StudentFirstNameLabel" runat="server" Text="First Name"></asp:Label><asp:TextBox ID="StudentFirstNameTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="StudentLastNameLabel" runat="server" Text="Last Name"></asp:Label><asp:TextBox ID="StudentLastNameTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="StudentDateOfBirthLabel" runat="server" Text="D.O.B"></asp:Label><asp:TextBox ID="StudentDateOfBirthTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="StudentEmailAddressLabel" runat="server" Text="Email Address"></asp:Label><asp:TextBox ID="StudentEmailAddressTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="StudentEmailConfirmationLabel" runat="server" Text="Confirm Email Address"></asp:Label><asp:TextBox ID="StudentEmailConfirmationTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="StudentPasswordLabel" runat="server" Text="Password"></asp:Label><asp:TextBox ID="StudentPasswordTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="StudentPasswordConfirmationLabel" runat="server" Text="Confirm Password"></asp:Label><asp:TextBox ID="StudentPasswordConfirmationTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="StudentCaptchaResponseLabel" runat="server" Text="Captcha Response"></asp:Label><asp:TextBox ID="StudentCaptchaResponseTextBox" runat="server"></asp:TextBox><br />
    </asp:Panel><br /> <br />
    <asp:Panel ID="LecturerRegistrationPanel" runat="server">
        <asp:Label ID="LecturerFirstNameLabel" runat="server" Text="First Name"></asp:Label><asp:TextBox ID="LecturerFirstNameTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerLastNameLabel" runat="server" Text="Last Name"></asp:Label><asp:TextBox ID="LecturerLastNameTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerPositionLabel" runat="server" Text="Lecturer's Position">
            </asp:Label><asp:DropDownList ID="LecturerPositionDropDownList" AutoPostBack="true" OnSelectedIndexChanged="LecturerPositionDropDownList_SelectedIndexChanged" runat="server">
                <asp:ListItem Selected="True" Value="Select Posistion"> Select Position</asp:ListItem>
                <asp:ListItem Value="Principal"> Principalt</asp:ListItem>
                <asp:ListItem Value="Head of The ICT Department"> Head of The ICt Department</asp:ListItem>
                <asp:ListItem Value="Lecturer"> Lecturer</asp:ListItem>
                <asp:ListItem Value="Lecturer's Assistant"> Lecturer's Assistant</asp:ListItem>
                <asp:ListItem Value="Secretary"> Secretary</asp:ListItem>
        </asp:DropDownList><br />
        <asp:Label ID="LecturerEmailAddressLabel" runat="server" Text="Email Address"></asp:Label><asp:TextBox ID="LecturerEmailAddressTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerEmailConfirmationLabel" runat="server" Text="Confirm Email Address"></asp:Label><asp:TextBox ID="LecturerEmailConfirmationTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerPasswordLabel" runat="server" Text="Password"></asp:Label><asp:TextBox ID="LecturerPasswordTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerPasswordConfirmationLabel" runat="server" Text="Confirm Password"></asp:Label><asp:TextBox ID="LecturerPasswordConfirmationTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerCaptchaResponseLabel" runat="server" Text="Captcha Response"></asp:Label><asp:TextBox ID="LecturerCaptchaResponseTextBox" runat="server"></asp:TextBox><br />
    </asp:Panel>

    </asp:Panel>
</asp:Content>

