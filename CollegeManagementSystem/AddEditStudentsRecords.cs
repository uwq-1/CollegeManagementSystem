using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public partial class AddEditStudentsRecords : Form
    {
        private bool isEditMode;
        private string fee;
        protected string _idNumber = "N/A";

        private ManageArchiveStudentRecords _manageArchiveStudentRecords = null;
        
        

        private readonly KUniversityDbModel kCollege_DbEntities;

        public AddEditStudentsRecords(ManageArchiveStudentRecords manageArchiveStudentRecords = null)
        {
            InitializeComponent();
            lblstudentRTitle.Text = "Add New Student";
            // Change titlebar of the window 
            // Reference : https://stackoverflow.com/questions/5104175/how-do-you-change-the-text-in-the-titlebar-in-windows-forms
            this.Text = "Add Student";

            isEditMode = false;
            _manageArchiveStudentRecords = manageArchiveStudentRecords;
            
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public AddEditStudentsRecords(StudentRegistrationRecord studentRegistration, ManageArchiveStudentRecords manageArchiveStudentRecords = null)
        {
            InitializeComponent();
            lblstudentRTitle.Text = "Edit Student";
            Text = "Edit Student";
            _manageArchiveStudentRecords = manageArchiveStudentRecords;
            

            if (studentRegistration == null)
            {
                MessageBox.Show("Please ensure that you select a valid row to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                kCollege_DbEntities = new KUniversityDbModel();
                PopulateFields(studentRegistration);
            }

            
        }

        

        public string GetRandomNumber()
        {
            Random r = new Random();
            int randomNumber = r.Next(100000, 9999999);
            lblstudentSRRandomNumber.Text = randomNumber.ToString();
            return randomNumber.ToString();
        }


        public string GetStudentId()
        {
            return _idNumber = GetRandomNumber();

        }

        private void PopulateFields(StudentRegistrationRecord studentRegistration)
        {
            lblSRId.Text = studentRegistration.id.ToString();
            txtstudentRecordsName.Text = studentRegistration.Name;
            lblstudentSRRandomNumber.Text = studentRegistration.Sid;
            txtstudentRecordsPhone.Text = studentRegistration.Phone;
            txtstudentRecordsEmail.Text = studentRegistration.Email;
            cbstudentSRProgramme.Text = studentRegistration.TypesOfProgramme.name;
            dtpstudentRecordsDOB.Value = (DateTime)studentRegistration.DateOfBirth;
        }


        private void btnsaveStudentRecordsChanges_Click(object sender, EventArgs e)
        {
            try
            {

                // Beginning of the code 
                string studentName = txtstudentRecordsName.Text;
                string studentEmail = txtstudentRecordsEmail.Text.ToString();
                string studentPhone = txtstudentRecordsPhone.Text.ToString();
                string studentProgramme = cbstudentSRProgramme.Text.ToString();
                DateTime studentDOB = (DateTime)dtpstudentRecordsDOB.Value;
                string associateDegree = "Associate Degree in Information Communication and Technology";
                string bachelorDegree = "Bachelor Degree in Information  Communication and Technology";
                string studentTution = txtstudentSRTutionFee.Text.ToString();

                studentTution = studentProgramme.Equals(associateDegree) ? "128000" : "256000";

                string studentRandomNo = lblstudentSRRandomNumber.Text;
                studentRandomNo = GetStudentId();
                var randomNo = "";

                randomNo = lblstudentSRRandomNumber.Text.Equals(studentRandomNo) ? studentRandomNo : "N/A";

                var isValid = true;
                var errorMessage = "";



                if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(studentProgramme))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing data.\n\r";
                }

                if (string.IsNullOrWhiteSpace(studentPhone) || string.IsNullOrWhiteSpace(studentEmail))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing data.\n\r";
                }


                if (studentProgramme.Equals(associateDegree))
                {
                    fee = "128000";
                    txtstudentSRTutionFee.ResetText();
                    txtstudentSRTutionFee.AppendText(fee);
                }

                if (studentProgramme.Equals(bachelorDegree))
                {
                    fee = "256000";
                    txtstudentSRTutionFee.ResetText();
                    txtstudentSRTutionFee.AppendText(fee);
                }

                // Condition used to check if phone number is 10 digits .
                if (!Regex.IsMatch(studentPhone, "^[0-9]{10}$"))
                {
                    isValid = false;
                    errorMessage += "Error : Phone number should contain only numbers or 10 digits.\n\r";
                    txtstudentRecordsPhone.Focus();

                }


                if (isValid == true)
                {

                    // if(isEditMode == true)
                    if (isEditMode)
                    {

                        // Edit Code here
                        var id = int.Parse(lblSRId.Text);
                        var studentRegistration = kCollege_DbEntities.
                            StudentRegistrationRecords
                            .FirstOrDefault(q => q.id == id);

                        studentRegistration.Name = txtstudentRecordsName.Text;
                        studentRegistration.Sid = lblstudentSRRandomNumber.Text;
                        studentRegistration.Phone = txtstudentRecordsPhone.Text;
                        studentRegistration.Email = txtstudentRecordsEmail.Text;
                        studentRegistration.DateOfBirth = dtpstudentRecordsDOB.Value;
                        studentRegistration.Stution = txtstudentSRTutionFee.Text;
                        studentRegistration.TypeOfProgrammeid = (int)cbstudentSRProgramme.SelectedValue;

                        
                        
                        kCollege_DbEntities.SaveChanges();
                        
                        MessageBox.Show($"Thanks for your submission.\n" +
                            $"Name : {studentName}  ID: {studentRandomNo} D-ID: {randomNo}\n\r" +
                            $"Student Phone : {studentPhone}\n\r" +
                            $"Student Email : {studentEmail}\n\r" +
                            $"Student DOB : {studentDOB}\n\r" +
                            $"Student Programmme : {studentProgramme}\n\r" +
                            $"Student Tution :$ {studentTution}");

                    }
                    else
                    {
                        // Add Code here

                        GetStudentId();

                        var studentRegistration = new StudentRegistrationRecord
                        {
                            Name = studentName,
                            Sid = studentRandomNo,
                            Phone = studentPhone,
                            Email = studentEmail,
                            Stution = studentTution,
                            DateOfBirth = studentDOB,

                            TypeOfProgrammeid = (int)cbstudentSRProgramme.SelectedValue
                        };
                        

                        kCollege_DbEntities.StudentRegistrationRecords.Add(studentRegistration);
                        

                        //GetStudentId();
                        MessageBox.Show($"Thanks for your submission.\n" +
                            $"Name : {studentName}  ID: {studentRandomNo} D-ID: {randomNo}\n\r" +
                            $"Student Phone : {studentPhone}\n\r" +
                            $"Student Email : {studentEmail}\n\r" +
                            $"Student DOB : {studentDOB}\n\r" +
                            $"Student Programmme : {studentProgramme}\n\r" +
                            $"Student Tution :$ {studentTution}");

                    }
                    
                    kCollege_DbEntities.SaveChanges();
                    
                    _manageArchiveStudentRecords.PopulateGrid();
                    
                    

                    MessageBox.Show("Operation completed.");
                    Close();


                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
                // End of if - else statement 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            
        }

        private void btncancelStudentRecordsChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEditStudentsRecords_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfProgramme
            var sprogrammes = kCollege_DbEntities.TypesOfProgrammes.ToList();
            cbstudentSRProgramme.DisplayMember = "Name";
            cbstudentSRProgramme.ValueMember = "id";
            cbstudentSRProgramme.DataSource = sprogrammes;
        }
    }
}
