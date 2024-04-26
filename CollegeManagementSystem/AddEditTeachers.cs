using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public partial class AddEditTeachers : Form
    {
        private bool isEditMode;
        string teacherBlank = "";
        protected string _idNumber = "N/A";


        private ManageTeacherRecords _manageTeacherRecords = null;

        private readonly KUniversityDbModel kCollege_DbEntities;

        public AddEditTeachers(ManageTeacherRecords manageTeacherRecords = null)
        {
            InitializeComponent();
            lblteacherGRTitle.Text = "Add New Teacher";

            this.Text = "Add Teacher";

            isEditMode = false;
            _manageTeacherRecords = manageTeacherRecords;
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public AddEditTeachers(TeacherRegistrationRecord teacherRegistration, ManageTeacherRecords manageTeacherRecords = null)
        {
            InitializeComponent();

            lblteacherGRTitle.Text = "Edit New Teacher";

            this.Text = "Edit Teacher";
            _manageTeacherRecords = manageTeacherRecords;

            if (teacherRegistration == null)
            {
                MessageBox.Show("Please ensure that you select a valid row to edit");
                Close();
            }
            else
            {
                isEditMode = true;

                kCollege_DbEntities = new KUniversityDbModel();
                PopulateFields(teacherRegistration);
            }

            
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


        private void PopulateFields(TeacherRegistrationRecord teacherRegistration)
        {

            lblSRId.Text = teacherRegistration.id.ToString();
            txtteacherName.Text = teacherRegistration.name;
            txtteacherPhone.Text = teacherRegistration.phone;
            txtteacherEmail.Text = teacherRegistration.email;
            dtpteacherDOB.Value = (DateTime)teacherRegistration.DateOfBirth;
            cbteacherSubjectArea.SelectedValue = teacherRegistration.TypesOfMajorSubjectsid.ToString();
        }

        public bool isValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public void TeacherClearButton()
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

        public void TeacherSubmitButton()
        {
            try
            {
                string teacherName = txtteacherName.Text;

                string teacherPhone = txtteacherPhone.Text.ToString();

                string teacherEmail = txtteacherEmail.Text.ToString();
                DateTime teacherDateOfBirth = dtpteacherDOB.Value;

                string teacherSubjectArea = cbteacherSubjectArea.Text;
                bool isValid = true;
                var errorMessage = "";

                string teacherRandomNo = lblteacherRandomNumber.Text;
                



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

                    if (isEditMode)
                    {
                        var id = int.Parse(lblSRId.Text);
                        var teacherRegistration = kCollege_DbEntities.
                            TeacherRegistrationRecords.
                            FirstOrDefault(q => q.id == id);

                        teacherRegistration.name = teacherName;
                        teacherRegistration.Tid = teacherRandomNo;
                        teacherRegistration.phone = teacherPhone;
                        teacherRegistration.email = teacherEmail;
                        teacherRegistration.DateOfBirth = teacherDateOfBirth;

                        teacherRegistration.TypesOfMajorSubjectsid = (int)cbteacherSubjectArea.SelectedValue;

                        kCollege_DbEntities.TeacherRegistrationRecords.Add(teacherRegistration);
                        kCollege_DbEntities.SaveChanges();

                        MessageBox.Show($"Thanks for your submission.\n" +
                        $"Name : {teacherName} ID: {teacherRandomNo} \n\r" +
                        $"Teacher Phone : {teacherPhone}\n\r" +
                        $"Teacher Email : {teacherEmail}\n\r" +
                        $"Teacher DOB : {teacherDateOfBirth}\n\r" +
                        $"Teacher Subject Major : {teacherSubjectArea}");


                    }
                    else
                    {
                        teacherRandomNo = GetTeacherId();

                        // Generate Default Password 
                        var defaultPassword = Utils.GenerateRandomPassword();
                        var generic_password = defaultPassword;
                        var password = Utils.HashPassword(generic_password);


                        var teacherRegistration = new TeacherRegistrationRecord 
                        {
                            name = teacherName,
                            Tid = teacherRandomNo,
                            phone = teacherPhone,
                            email = teacherEmail,
                            DateOfBirth = teacherDateOfBirth,
                            TdefaultPassword = password,

                            TypesOfMajorSubjectsid = (int)cbteacherSubjectArea.SelectedValue
    

                        };


                        // stored primary key id
                        int teacherPrimaryKey = teacherRegistration.id;

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


                        kCollege_DbEntities.TeacherRegistrationRecords.Add(teacherRegistration);

                        
                        MessageBox.Show($"Thanks for your submission.\n" +
                        $"Name : {teacherName} ID: {teacherRandomNo}  Default Password: {generic_password}\n\r" +
                        $"Teacher Phone : {teacherPhone}\n\r" +
                        $"Teacher Email : {teacherEmail}\n\r" +
                        $"Teacher DOB : {teacherDateOfBirth}\n\r" +
                        $"Teacher Subject Major : {teacherSubjectArea}");


                    }
                    kCollege_DbEntities.SaveChanges();

                    _manageTeacherRecords.PopulateGrid();
                    
                    MessageBox.Show("Operation completed.");
                    Close();

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

        private void btnsaveTeacherRChanges_Click(object sender, EventArgs e)
        {
            TeacherSubmitButton();
        }

        private void btncancelTeacherRChanges_Click(object sender, EventArgs e)
        {
            TeacherClearButton();
        }

        private void AddEditTeachers_Load(object sender, EventArgs e)
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
