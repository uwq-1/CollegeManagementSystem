﻿using Microsoft.Ajax.Utilities;
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
        private string studentUsername = string.Empty;
        private string studentEmail = string.Empty;
        private string studentEmailConfirmation;
        private DateTime studentDOB;
        private string studentPassword = string.Empty;
        private string studentPasswordConfirmation;
        private string studentProgrammeCode;
        private string studentProgrammeName;
        private string lecturerFirstName = string.Empty;
        private string lecturerLastName = string.Empty;
        private string lecturerUsername = string.Empty;
        private string lecturerPosition = string.Empty;
        private string lecturerEmail;
        private string lecturerEmailConfirmation;
        private string lecturerPassword = string.Empty;
        private string lecturerPasswordConfirmation;
        private string captchaCode;
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
            //StudentErrorLabel.Visible = false;

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

            studentFirstName = StudentFirstNameTextBox.Text;
            studentLastName = StudentLastNameTextBox.Text;
            studentUsername = StudentUsernameTextBox.Text;
            //studentDOB = ;
            studentEmail = StudentEmailAddressTextBox.Text;
            studentEmailConfirmation = StudentEmailConfirmationTextBox.Text;
            studentPassword = StudentPasswordTextBox.Text;
            studentPasswordConfirmation = StudentPasswordConfirmationTextBox.Text;
            studentProgrammeCode = StudentProgrammeDropDownList.SelectedValue;
            studentProgrammeName = StudentProgrammeDropDownList.Text;

            captchaCode = StudentCaptchaResponseTextBox.Text;


            //Checking if the fields are empty
            if (!studentFirstName.IsNullOrWhiteSpace() && !studentLastName.IsNullOrWhiteSpace() && !studentEmail.IsNullOrWhiteSpace() && !studentEmailConfirmation.IsNullOrWhiteSpace() 
                && !studentPassword.IsNullOrWhiteSpace() && !studentPasswordConfirmation.IsNullOrWhiteSpace() && studentProgrammeCode != "" && !studentUsername.IsNullOrWhiteSpace()) 
            {
                //confirming email address is entered correctly twice
               if (studentEmail != studentEmailConfirmation)
                {
                    StudentErrorLabel.Text = "Email address does not match!";
                }

                //confirming password is entered correctly twice
                if (studentPassword != studentPasswordConfirmation)
                {
                    StudentErrorLabel.Text = "Password does not match!";
                }

                PersonName studentName = new PersonName(studentFirstName, studentLastName);   //  created an instance of a class which is an object.
                Programs programs = new Programs(studentProgrammeName, studentProgrammeCode);

                Student student = new Student(studentName, programs, studentEmail);
                student.LoginName = studentUsername;
                student.Password = studentPassword;
            }
            else
            {
                StudentErrorLabel.Text = "Please complete ALL feilds";
            }

           
        }

        protected void LecturerSubmitButton_Click(object sender, EventArgs e)
        {
            //submit the lecturer registration information
        }
    }
}