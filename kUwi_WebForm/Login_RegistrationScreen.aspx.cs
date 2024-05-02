using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kUwi_WebForm
{
    public partial class Login_RegistrationScreen : System.Web.UI.Page
    {
        private string userName = string.Empty;//defined variables
        private string password = string.Empty;
        private string studentFirstName = string.Empty;
        private string studentLastName = string.Empty;
        private string studentEmail = string.Empty;
        private string studentEmailverified = string.Empty;
        private string dob = string.Empty;//how do I get this to be a calender format or datetime?
        private string studentPassword = string.Empty;
        private string studentPasswordverified = string.Empty;
        private string lecturerFirstName = string.Empty;
        private string lecturerLastName = string.Empty;
        private string lecturerPosition = string.Empty;
        private string lecturerEmail = string.Empty;
        private bool lecturerEmailVerified = false;//ask vhas if this can work for this screen or just for the login section
        private string lecturerPassword = string.Empty;
        private string lecturerPasswordverified = string.Empty; // or if i should put the verified on the password field. I think i know the answer to this because I should only be collecting data here.
        private protected int studentId_num = 0;//also ask is what is writen here can work
        private protected int  lecturerId_num = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { //validation check on page load
                if (userName == string.Empty && password == string.Empty)
                {
                    //grey out/ disable the login button
                    LoginButton.Enabled = false;
                }
                //disable registration panel until regsitration link is clicked
                //Registration.Enabled = false ;
                Registration.Visible = false ;
                //disable registration panel until regsitration link is clicked
               // Registration.Enabled = false;
                StudentRegistrationPanel.Visible = false;
                LecturerRegistrationPanel.Visible=false;
            }
            //disable registration panel until regsitration link is clicked
            //Registration.Enabled = false;
            Registration.Visible = false;
            StudentRegistrationPanel.Visible = false;
            LecturerRegistrationPanel.Visible = false;

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //get username entered from username textbox
            userName = UsernameTextBox.Text;

            //get password entered from password textbox
            password = PasswordTextBox.Text;

            //put text in username variable
            //put text in password variable
            //validate the information entered in the textboxes
            

            //check against the store information in the database
            //if correct, display home screen
            //if incorrect, prompt user to enter the correct details
        }

        protected void Lecturer_StudentRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check which radio button is selected

            if (Lecturer_StudentRadioButtonList.SelectedValue.Trim() == "Student")
            {
                StudentRegistrationPanel.Visible = true;
                LecturerRegistrationPanel.Visible = false;
                Registration.Visible = true;
            }
            else
            {
                LecturerRegistrationPanel.Visible = true;
                StudentRegistrationPanel.Visible = false;
                Registration.Visible = true;
            }
            //== means a check.
            //display student registration panel when selected
            //display lecturer registration panel when selected
        }

        protected void RegistrationLinkButton_Click(object sender, EventArgs e)
        {
            //when the registration link is clicked, display the registration panel
            //Registration.Enabled = true ;
            //Login.Enabled = false ;
            Registration.Visible = true ;
            Login.Visible = false ;
        }

        protected void LecturerPositionDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void StudentSubmitButton_Click(object sender, EventArgs e)
        {
            //submit the student registration information
        }

        protected void LecturerSubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}