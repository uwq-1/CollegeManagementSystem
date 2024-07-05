using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CollegeManagementSystem
{
    public partial class StudentGradesWindow : Form
    {
        private readonly KUniversityDbModel kCollege_DbEntities;

        private string studentBlank = "";
        public int Average, sum = 0;

        public StudentGradesWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public void StudentGradeClearButton() 
        {
            try
            {
                string courseGDescription = txtstudentGComments.Text;
                int j = 0;
                var courseGGrades = txtstudentGGrades.Text
                                    .Split(',')
                                    .Select(m => Int32.Parse(m.Trim()))
                                    .ToArray();

                int courseGNoOfGrades = Convert.ToInt32(txtstudentGNoOfGrades.Text);
                string s = "";

                if (courseGDescription != string.Empty)
                {
                    txtstudentGComments.ResetText();
                    txtstudentGComments.AppendText(studentBlank);
                }

                // Clear Integer textbox
                // Reference :
                // https://stackoverflow.com/questions/16734172/checking-a-textbox-for-an-empty-string-an-integer-or-a-string
                if (!int.TryParse(s,out courseGGrades[j]))
                {
                    txtstudentGGrades.ResetText();
                    txtstudentGGrades.AppendText(studentBlank);
                    txtstudentGGrades.Clear();
                }


                if (!int.TryParse(s, out courseGNoOfGrades))
                {
                    txtstudentGNoOfGrades.ResetText();
                    txtstudentGNoOfGrades.AppendText(studentBlank);
                    txtstudentGNoOfGrades.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        public void StudentGradeSubmitButton()
        {
            try
            {
                string courseGId = cbstudentGCourseId.Text;
                string courseGName = cbstudentGCourseName.Text;
                string courseGStudentName = cbstudentGName.Text;
                string courseGStudentId = cbstudentGIdNo.Text;
                string courseGLecturer = cbstudentGLecturer.Text;
                string courseGDescription = txtstudentGComments.Text;

                int courseGNoOfGrades = Convert.ToInt32(txtstudentGNoOfGrades.Text);
                //int courseGGrades = Convert.ToInt32(txtstudentGGrades.Text);


                int j = 0;

                //int[] courseGGrades = new int[courseGNoOfGrades];
                
                

                bool isValid = true;
                string errorMessage = "";

                
                if (string.IsNullOrWhiteSpace(courseGLecturer)
                    || string.IsNullOrWhiteSpace(courseGDescription))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing Lecturer and/or Description.\n\r";
                    cbstudentGLecturer.Focus();
                }


                // Reference : https://stackoverflow.com/questions/14667234/how-can-i-enter-multiple-doubles-into-a-textbox-separated-by-commas-and-store-in

                var courseGGrades = txtstudentGGrades.Text
                                    .Split(',')
                                    .Select(m => Int32.Parse(m.Trim()))
                                    .ToArray();

                

                if (courseGGrades[j] >= 0 && courseGGrades[j] <= 100)
                {
                    for (int i = 0; i < courseGNoOfGrades; i++)
                    {
                        //courseGGrades;
                        sum += courseGGrades[j];
                        j++;
                    }
                    
                    Average = sum / courseGNoOfGrades;
                    // true

                    var result = "";

                    foreach (var item in courseGGrades)
                    {
                        //MessageBox.Show($"Your have earned. {item}%");
                        result += item + "\n";
                    }
                    MessageBox.Show($"Your have earned. : \n\r" +
                        $" {result}%");
                    //MessageBox.Show($"Your have earned. {courseGGrades}%");
                    MessageBox.Show($"Your average is :  {Average}%");
                    
                }
                /*else
                {
                    // false
                    MessageBox.Show("Error : Invalid value entered.\n\r");
                    // errorMessage += "Error : Invalid value entered.\n\r";
                }*/

                

                if (isValid == true)
                {
                    var result = "";
                    
                    foreach (var item in courseGGrades)
                    {
                        //MessageBox.Show($"Your have earned. {item}%");
                        //MessageBox.Show($"{result}%");
                        result += item + ",";
                    }
                    List<int> gradesNumbersList = courseGGrades.ToList();

                    
                    
                    var studentGradesRecordsDb = new StudentGradesRegistrationRecord();
                    studentGradesRecordsDb.Coursename = courseGName;
                    studentGradesRecordsDb.Cid = courseGId;
                    studentGradesRecordsDb.Lecturername = courseGLecturer;
                    studentGradesRecordsDb.Sname = courseGStudentName;
                    studentGradesRecordsDb.Sid = courseGStudentId;
                    studentGradesRecordsDb.Scomments = courseGDescription;
                    //studentGradesRecordsDb.Sgrade = (int?)courseGGrades;
                    studentGradesRecordsDb.Sgrade = gradesNumbersList.FirstOrDefault();
                    studentGradesRecordsDb.AverageGrade = Average;
                    studentGradesRecordsDb.NumOfGrades = courseGNoOfGrades;
                    


                    kCollege_DbEntities.StudentGradesRegistrationRecords.Add(studentGradesRecordsDb);
                    kCollege_DbEntities.SaveChanges();


                    // Display output with Messagebox
                    MessageBox.Show($"Thanks for your submission.\n" +
                        $"Course Name : {courseGName} Course ID: {courseGId} \n\r" +
                        $"Lecturer : {courseGLecturer}\n\r" +
                        $"Student Name : {courseGStudentName}  Student Id: {courseGStudentId}\n\r" +
                        $"Description : {courseGDescription}\n\r" +
                        $"Grade : {result}");

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


        private void btnstudentGradesSubmit_Click(object sender, EventArgs e)
        {
            
            StudentGradeSubmitButton();
            
        }

        private void btnstudentGradesClear_Click(object sender, EventArgs e)
        {
            StudentGradeClearButton();
        }

        private void pbHelpNoOfGrades_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipNoOfGrades = new ToolTip();

            toolTipNoOfGrades.SetToolTip(this.pbHelpNoOfGrades, "Enter numbers only example : 4 ");

        }

        private void pbGrades_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipGrades = new ToolTip();

            toolTipGrades.SetToolTip(this.pbGrades, "Format for Grades assuming you enter four above eg : 10,40,60,90");
        }

        private void StudentGradesWindow_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfCourses
            
            var sgradesrecords = kCollege_DbEntities.TypesOfCourses.ToList();
            cbstudentGCourseId.DisplayMember = "Cid";
            cbstudentGCourseId.ValueMember = "id";
            cbstudentGCourseName.DisplayMember = "Name";
            cbstudentGCourseName.ValueMember = "id";
            cbstudentGCourseName.DataSource = sgradesrecords;
            cbstudentGCourseId.DataSource = sgradesrecords;


            var sgradesrecordsname = kCollege_DbEntities.StudentRegistrationRecords
                .ToList();
            
            cbstudentGIdNo.DisplayMember = "Sid";
            cbstudentGIdNo.ValueMember = "id";
            cbstudentGIdNo.DataSource = sgradesrecordsname;


            cbstudentGName.DisplayMember = "Name";
            cbstudentGName.ValueMember = "id";
            cbstudentGName.DataSource = sgradesrecordsname;

            var sgradesteachersname = kCollege_DbEntities
                .TeacherRegistrationRecords
                .ToList();

            cbstudentGLecturer.DisplayMember = "Name";
            cbstudentGLecturer.ValueMember = "id";
            cbstudentGLecturer.DataSource = sgradesteachersname;


        }

    }
}
