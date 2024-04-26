using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public partial class TeacherWindow : Form
    {
        string teacherBlank = "";
        protected string _idNumber = "N/A";
        protected string _genericPassword = "";
        public string teacherDefaultPassword;


        private readonly KUniversityDbModel kCollege_DbEntities;

        public TeacherWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public string GetRandomNumber()
        {
            Random r = new Random();
            int randomNumber = r.Next(100000, 9999999);
            lblteacherRandomNumber.Text = randomNumber.ToString();
            return randomNumber.ToString(); 
        }

        public string GetTeacherId()
        {
            return _idNumber = GetRandomNumber();
        }


        public string GetTeacherPassword()
        {
            return _genericPassword = Utils.GenerateRandomPassword();
        }

        private void teacherResetButton()
        {
            string teacherName = txtteacherName.Text;

            string teacherPhone = txtteacherPhone.Text;

            string teacherEmail = txtteacherEmail.Text;

            string teacherID = lblteacherRandomNumber.Text;

            if (teacherName != string.Empty)
            {
                txtteacherName.ResetText();
                txtteacherName.AppendText(teacherBlank);
            }

            if (teacherPhone != string.Empty)
            {
                txtteacherPhone.ResetText();
                txtteacherPhone.AppendText(teacherBlank);
            }

            if (teacherEmail != string.Empty)
            {
                txtteacherEmail.ResetText();
                txtteacherEmail.AppendText(teacherBlank);
            }


            if (teacherID != string.Empty)
            {
                lblteacherRandomNumber.Text = "";
            }

        }

        public bool isValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnteacherSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string teacherName = txtteacherName.Text;

                string teacherPhone = txtteacherPhone.Text.ToString();

                string teacherEmail = txtteacherEmail.Text.ToString();
                DateTime teacherDateOfBirth = dtpteacherDateOfBirth.Value;

                string teacherSubjectArea = cbteacherSubjectArea.Text;
                bool isValid = true;
                var errorMessage = "";

                string teacherRandomNo = lblteacherRandomNumber.Text;




                if (string.IsNullOrWhiteSpace(teacherName) || string.IsNullOrWhiteSpace(teacherSubjectArea))
                {
                    isValid = false;
                    teacherDefaultPassword = "";
                    lblteacherRandomNumber.ResetText();
                    errorMessage += "Error : Please enter missing data.\n\r";
                    txtteacherName.Focus();

                }

                if (string.IsNullOrEmpty(teacherPhone) || string.IsNullOrEmpty(teacherEmail))
                {
                    isValid = false;
                    isValidEmail(teacherEmail);
                    teacherDefaultPassword = "";
                    lblteacherRandomNumber.ResetText();
                    errorMessage += "Error : Please enter correct information.\n\r";
                }

                // Condition used to check if phone number is 10 digits .
                if (!Regex.IsMatch(teacherPhone, "^[0-9]{10}$"))
                {
                    isValid = false;
                    errorMessage += "Error : Phone number should contain only numbers or 10 digits.\n\r";

                }

                if (isValid == true)
                {
                    teacherRandomNo = GetTeacherId();
                    // Generate Default Password 
                    teacherDefaultPassword = GetTeacherPassword();
                    var generic_password = teacherDefaultPassword;
                    var password = Utils.HashPassword(teacherDefaultPassword);


                    var teacherRecords = new TeacherRegistrationRecord();
                    teacherRecords.name = teacherName;
                    teacherRecords.Tid = teacherRandomNo;
                    teacherRecords.phone = teacherPhone;
                    teacherRecords.email = teacherEmail;

                    teacherRecords.DateOfBirth = teacherDateOfBirth;
                    teacherRecords.TdefaultPassword = password;

                    teacherRecords.TypesOfMajorSubjectsid = (int)cbteacherSubjectArea.SelectedValue;

                    // stored primary key id
                    int teacherPrimaryKey = teacherRecords.id;

                    var loginRecords = new LoginRecord
                    {
                        teacherid = teacherPrimaryKey,
                        username = teacherRandomNo,
                        password = password,
                        isDefaultPassword = true,
                        isActive = true

                    };

                    var userRoles = new UserRole
                    {
                        userid = teacherPrimaryKey,
                        roleid = 2
                    };



                    kCollege_DbEntities.LoginRecords.Add(loginRecords);

                    kCollege_DbEntities.UserRoles.Add(userRoles);


                    kCollege_DbEntities.TeacherRegistrationRecords.Add(teacherRecords);
                    kCollege_DbEntities.SaveChanges();


                    MessageBox.Show($"Thanks for your submission.\n" +
                    $"Name : {teacherName} ID: {teacherRandomNo} Default Password: {generic_password} \n\r" +
                    $"Teacher Phone : {teacherPhone}\n\r" +
                    $"Teacher Email : {teacherEmail}\n\r" +
                    $"Teacher DOB : {teacherDateOfBirth}\n\r" +
                    $"Teacher Subject Major : {teacherSubjectArea}");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btnteacherClear_Click(object sender, EventArgs e)
        {
            teacherResetButton();
        }

        private void TeacherWindow_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfMajorSubjects
            
            var teacherrecords = kCollege_DbEntities
                .TypesOfMajorSubjects
                .ToList();

            cbteacherSubjectArea.DisplayMember = "Name";
            cbteacherSubjectArea.ValueMember = "id";
            cbteacherSubjectArea.DataSource = teacherrecords;
        }
    }
}
