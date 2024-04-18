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
    public partial class StudentWindow : Form
    {
        string studentBlank = "";
        string fee;
        protected string _idNumber = "N/A";


        private readonly KUniversityDbModel kCollege_DbEntities; 

        public StudentWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();

        }
        

        public  string GetRandomNumber()
        {
            Random r = new Random();
            int randomNumber = r.Next(100000, 9999999);
            lblstudentRandomNumber.Text = randomNumber.ToString();
            return randomNumber.ToString();
        }
        

        public string GetStudentId()
        {
            return _idNumber = GetRandomNumber();
            
        }

        private void studentResetButton()
        {

            string studentName = txtstudentName.Text;
            string studentPhone = txtstudentPhone.Text;
            string studentEmail = txtstudentEmail.Text;
            string studentTution = txtstudentTutionFee.Text;

            string studentID = lblstudentRandomNumber.Text;


            string studentProgramme = cbstudentProgramme.Text.ToString();
            string associateDegree = "Associate Degree in Information Communication and Technology";
            string bachelorDegree = "Bachelor Degree in Information  Communication and Technology";

            if (studentName != string.Empty)
            {
                //studentName = "";
                txtstudentName.ResetText();
                txtstudentName.AppendText(studentBlank);

            }

            if (studentPhone != string.Empty)
            {
                txtstudentPhone.ResetText();
                txtstudentPhone.AppendText(studentBlank);
            }

            if (studentEmail != string.Empty || studentTution != string.Empty)
            {
                txtstudentEmail.ResetText();
                txtstudentEmail.AppendText(studentBlank);
                txtstudentTutionFee.ResetText();
                txtstudentTutionFee.AppendText(studentBlank);
            }

            // Reference to clear a combobox 
            // https://stackoverflow.com/questions/9321844/how-do-i-clear-a-combobox
            if (studentProgramme.Equals(associateDegree) || studentProgramme.Equals(bachelorDegree))
            {
                cbstudentProgramme.Items.Clear();
                cbstudentProgramme.ResetText();  
            }

            if (studentID != string.Empty)
            {
                lblstudentRandomNumber.Text = "";
            }

            //Close();
        }

        public bool isValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnstudentSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string studentName = txtstudentName.Text;
                string studentPhone = txtstudentPhone.Text.ToString();
                string studentEmail = txtstudentEmail.Text.ToString();
                string studentTution = txtstudentTutionFee.Text.ToString();
                
                DateTime studentDateOfBirth = dtpstudentDateOfBirth.Value;

                string studentProgramme = cbstudentProgramme.Text.ToString();

                string studentRandomNo = lblstudentRandomNumber.Text;
                //studentRandomNo = GetRandomNumber();
                studentRandomNo = GetStudentId();

                

                string associateDegree = "Associate Degree in Information Communication and Technology";
                string bachelorDegree = "Bachelor Degree in Information  Communication and Technology";

                studentTution = studentProgramme.Equals(associateDegree) ? "128000" : "256000"; 

                bool isValid = true;
                var errorMessage = "";

                if (studentProgramme.Equals(associateDegree))
                {
                    fee = "128000";
                    txtstudentTutionFee.ResetText();
                    txtstudentTutionFee.AppendText(fee);
                }

                if (studentProgramme.Equals(bachelorDegree))
                {
                    fee = "256000";
                    txtstudentTutionFee.ResetText();
                    txtstudentTutionFee.AppendText(fee);
                }

                if (string.IsNullOrWhiteSpace(studentName))
                {
                    isValid = false;
                    lblstudentRandomNumber.ResetText();
                    errorMessage += "Error : Please enter missing data.\n\r";
                    txtstudentName.Focus();
                }

                if (string.IsNullOrWhiteSpace(studentProgramme))
                {
                    isValid = false;
                    lblstudentRandomNumber.ResetText();
                    errorMessage += "Error : Please enter missing data.\n\r";
                    cbstudentProgramme.Focus();
                }

                if (string.IsNullOrWhiteSpace(studentPhone) || string.IsNullOrWhiteSpace(studentEmail))
                {
                    isValid = false;
                    isValidEmail(studentEmail);
                    lblstudentRandomNumber.ResetText();
                    errorMessage += "Error : Please enter correct information.\n\r";
                    txtstudentEmail.Focus();
                }


                // Condition used to check if phone number is 10 digits .
                if (!Regex.IsMatch(studentPhone, "^[0-9]{10}$"))
                {
                    isValid = false;
                    errorMessage += "Error : Phone number should contain only numbers or 10 digits.\n\r";
                    txtstudentPhone.Focus();

                }

                if (isValid == true)
                {

                    var studentRecords = new StudentRegistrationRecord();
                    studentRecords.Name = studentName;
                    studentRecords.Sid = studentRandomNo;
                    studentRecords.Phone = studentPhone;
                    studentRecords.Email = studentEmail;    
                    studentRecords.Stution = studentTution;
                    studentRecords.DateOfBirth = studentDateOfBirth;

                    studentRecords.TypeOfProgrammeid = (int)cbstudentProgramme.SelectedValue;

                    kCollege_DbEntities.StudentRegistrationRecords.Add(studentRecords);
                    kCollege_DbEntities.SaveChanges();

                    GetStudentId();
                    MessageBox.Show($"Thanks for your submission.\n" +
                        $"Name : {studentName}  ID: {studentRandomNo}\n\r" +
                        $"Student Phone : {studentPhone}\n\r" +
                        $"Student Email : {studentEmail}\n\r" +
                        $"Student DOB : {studentDateOfBirth}\n\r" +
                        $"Student Programmme : {studentProgramme}\n\r" +
                        $"Student Tution :$ {studentTution}");
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

        private void btnstudentClear_Click(object sender, EventArgs e)
        {
            //Close();
            studentResetButton();
        }

        private void StudentWindow_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfProgramme
            var sprogrammes = kCollege_DbEntities.TypesOfProgrammes.ToList();
            cbstudentProgramme.DisplayMember = "Name";
            cbstudentProgramme.ValueMember = "id";
            cbstudentProgramme.DataSource = sprogrammes;
        }
    }
}
