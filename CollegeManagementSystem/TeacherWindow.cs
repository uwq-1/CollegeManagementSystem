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

        private async void btnteacherSubmit_Click(object sender, EventArgs e)
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
                teacherRandomNo = GetTeacherId();



                if (string.IsNullOrWhiteSpace(teacherName) || string.IsNullOrWhiteSpace(teacherSubjectArea))
                {
                    isValid = false;
                    lblteacherRandomNumber.ResetText();
                    errorMessage += "Error : Please enter missing data.\n\r";
                    txtteacherName.Focus();
                    
                }

                if (string.IsNullOrEmpty(teacherPhone) || string.IsNullOrEmpty(teacherEmail))
                {
                    isValid = false;
                    isValidEmail(teacherEmail);
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

                    var teacherRecords = new TeacherRegistrationRecord();
                    teacherRecords.name = teacherName;
                    teacherRecords.Tid = teacherRandomNo;
                    teacherRecords.phone = teacherPhone;
                    teacherRecords.email = teacherEmail;
                    //teacherRecords.TypesOfMajorSubject = teacherSubjectArea;
                    teacherRecords.DateOfBirth = teacherDateOfBirth;

                    teacherRecords.TypesOfMajorSubjectsid = (int)cbteacherSubjectArea.SelectedValue;

                    kCollege_DbEntities.TeacherRegistrationRecords.Add(teacherRecords);
                    kCollege_DbEntities.SaveChanges();



                    GetTeacherId();
                    MessageBox.Show($"Thanks for your submission.\n" +
                    $"Name : {teacherName} ID: {teacherRandomNo} \n\r" +
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
                //throw;
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
