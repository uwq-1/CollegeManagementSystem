<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/KIWA.Master" CodeBehind="Login_RegistrationScreen.aspx.cs" Inherits="kUwi_WebForm.Login_RegistrationScreen" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Login" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LoginLabel" runat="server" Text="LOGIN"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="UsernameLabel" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="PasswordLabel" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="RegistrationLinkButton" runat="server" OnClick="RegistrationLinkButton_Click" Text="Sign Up"></asp:LinkButton>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        <br />

    </asp:Panel>
    <asp:Panel ID="Registration" runat="server">
        <asp:RadioButtonList ID="Lecturer_StudentRadioButtonList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Lecturer_StudentRadioButtonList_SelectedIndexChanged">
            <asp:ListItem>Lecturer </asp:ListItem>
            <asp:ListItem>Student </asp:ListItem>
            </asp:RadioButtonList><br /><br />
    <asp:Panel ID="StudentRegistrationPanel" runat="server">
        <asp:Label ID="StudentFirstNameLabel" runat="server" Text="First Name "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="StudentFirstNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="StudentLastNameLabel" runat="server" Text="Last Name "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="StudentLastNameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="StudentUserNameLabel" runat="server" Text="Username "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="StudentUsernameTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="StudentDateOfBirthLabel" runat="server" Text="D.O.B "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="StudentDateOfBirthTextBox" runat="server" TextMode="Date"></asp:TextBox><br />
        <asp:Label ID="StudentEmailAddressLabel" runat="server" Text="Email Address "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="StudentEmailAddressTextBox" runat="server" TextMode="Email"></asp:TextBox><br />
        <asp:Label ID="StudentEmailConfirmationLabel" runat="server" Text="Confirm Email Address "></asp:Label> &nbsp; <asp:TextBox ID="StudentEmailConfirmationTextBox" runat="server" TextMode="Email"></asp:TextBox><br />
        <asp:Label ID="StudentPasswordLabel" runat="server" Text="Password "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="StudentPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        <br />        
        <asp:Label ID="StudentPasswordConfirmationLabel" runat="server" Text="Confirm Password "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="StudentPasswordConfirmationTextBox"  runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="StudentProgramLabel" runat="server" Text="Programme "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="StudentProgrammeDropDownList" runat="server">
            <asp:ListItem Selected ="True" Value=""> Select Program</asp:ListItem>
            <asp:ListItem Value="ICT"> Information & Communication Technology </asp:ListItem>
            <asp:ListItem Value="BCON"> Building Construction </asp:ListItem>
            <asp:ListItem Value="BMGT"> Business Management </asp:ListItem>
            </asp:DropDownList>
        <br />
        <asp:Label ID="StudentCaptchaResponseLabel" runat="server" Text="Captcha Response "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="StudentCaptchaResponseTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="StudentSubmitButton" runat="server" OnClick="StudentSubmitButton_Click" Text="Submit" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="StudentErrorLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:RegularExpressionValidator id="StudentPasswordRegularExpressionValidator" 
                     ControlToValidate="StudentPasswordTextBox"
                     ValidationExpression="\w{8}$"
                     Display="Static"
                     ErrorMessage="Password must be at least 8 characters"
                     EnableClientScript="False" 
                     runat="server"/>
        <asp:RegularExpressionValidator id="StudentPasswordConfirmationRegularExpressionValidator" 
             ControlToValidate="StudentPasswordConfirmationTextBox"
             ValidationExpression="\w{8}$"
             Display="Static"
             ErrorMessage="Password must be at least 8 characters"
             EnableClientScript="False" 
             runat="server" />
       </asp:Panel><br /> <br />
    <asp:Panel ID="LecturerRegistrationPanel" runat="server">
        <asp:Label ID="LecturerFirstNameLabel" runat="server" Text="First Name "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="LecturerFirstNameTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerLastNameLabel" runat="server" Text="Last Name "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="LecturerLastNameTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerUsernameLabel" runat="server" Text="Username "></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="LecturerUsernameTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerPositionLabel" runat="server" Text="Lecturer's Position ">
            </asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="LecturerPositionDropDownList" AutoPostBack="true" OnSelectedIndexChanged="LecturerPositionDropDownList_SelectedIndexChanged" runat="server">
                <asp:ListItem Selected="True" Value="Select Posistion"> Select Position</asp:ListItem>
                <asp:ListItem Value="PRIN"> Principal</asp:ListItem>
                <asp:ListItem Value="VP"> VICE Principal</asp:ListItem>
                <asp:ListItem Value="H_ICT"> Head of The ICt Department</asp:ListItem>
                <asp:ListItem Value="LEC"> Lecturer</asp:ListItem>
                <asp:ListItem Value="LEC_ASS"> Lecturer's Assistant</asp:ListItem>
                <asp:ListItem Value="SEC"> Secretary</asp:ListItem>
        </asp:DropDownList><br />
        <asp:Label ID="LecturerEmailAddressLabel" runat="server" Text="Email Address "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="LecturerEmailAddressTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerEmailConfirmationLabel" runat="server" Text="Confirm Email Address "></asp:Label>&nbsp; <asp:TextBox ID="LecturerEmailConfirmationTextBox" runat="server" Width="128px"></asp:TextBox><br />
        <asp:Label ID="LecturerPasswordLabel" runat="server" Text="Password "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="LecturerPasswordTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerPasswordConfirmationLabel" runat="server" Text="Confirm Password "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="LecturerPasswordConfirmationTextBox" runat="server"></asp:TextBox><br />
        <asp:Label ID="LecturerCaptchaResponseLabel" runat="server" Text="Captcha Response "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="LecturerCaptchaResponseTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="LecturerSubmitButton" runat="server" OnClick="LecturerSubmitButton_Click" Text="Submit" />
&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="LecturerErrorLabel" runat="server" Text=""></asp:Label>
        <br />
    </asp:Panel>

    </asp:Panel>
    </asp:Content>


