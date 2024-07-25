using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public partial class AddEditGrades : Form
    {
        private bool isEditMode;
        private string studentBlank = "";

        public int Average, sum = 0;

        private ManageGradesRecords _manageGradesRecords = null;

        private readonly KUniversityDbModel kCollege_DbEntities;


        public AddEditGrades(ManageGradesRecords manageGradesRecords = null)
        {
            InitializeComponent();
            lblstudentGRTitle.Text = "Add New Grades";
            this.Text = "Add Grades";

            isEditMode = false;
            _manageGradesRecords = manageGradesRecords;
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public AddEditGrades(StudentGradesRegistrationRecord  studentGradesRegistration, ManageGradesRecords manageGradesRecords = null)
        {
            InitializeComponent();
            lblstudentGRTitle.Text = "Edit New Grades";
            this.Text = "Edit Grades";
            _manageGradesRecords = manageGradesRecords;


            if (studentGradesRegistration == null)
            {
                MessageBox.Show("Please ensure that you select a valid row to edit");
                Close();
            }
            else
            {
                isEditMode = true;

                kCollege_DbEntities = new KUniversityDbModel();
                PopulateFields(studentGradesRegistration);
            }

            

        }


        private void PopulateFields(StudentGradesRegistrationRecord studentGradesRegistration)
        {
            lblSRId.Text = studentGradesRegistration.id.ToString();
            cbstudentGRCourseId.Text = studentGradesRegistration.Cid;
            cbstudentGRCourseName.Text = studentGradesRegistration.Coursename;
            cbstudentGRIdNo.Text = studentGradesRegistration.Sid;
            cbstudentGRName.Text = studentGradesRegistration.Sname;
            cbstudentGRLecturer.Text = studentGradesRegistration.Lecturername;
            txtstudentGRComments.Text = studentGradesRegistration.Scomments;
            
            txtstudentGRGrades.Text = studentGradesRegistration.Sgrade.ToString();
            txtstudentGRNoOfGrades.Text = studentGradesRegistration.NumOfGrades.ToString();
           

        }

        public void StudentGradeClearButton()
        {
            try
            {
                string courseGDescription = txtstudentGRComments.Text;

                int j = 0;
                var courseGGrades = txtstudentGRGrades.Text
                                    .Split(',')
                                    .Select(m => Int32.Parse(m.Trim()))
                                    .ToArray();

                int courseGNoOfGrades = Convert.ToInt32(txtstudentGRNoOfGrades.Text);
                

                
                //string errorMessage = "";
                string s = "";

                if (courseGDescription != string.Empty)
                {
                    txtstudentGRComments.ResetText();
                    txtstudentGRComments.AppendText(studentBlank);
                }

                // Clear Integer textbox
                // Reference :
                // https://stackoverflow.com/questions/16734172/checking-a-textbox-for-an-empty-string-an-integer-or-a-string
                if (!int.TryParse(s, out courseGGrades[j]))
                {
                    txtstudentGRGrades.ResetText();
                    txtstudentGRGrades.AppendText(studentBlank);
                    txtstudentGRGrades.Clear();
                }

                if (!int.TryParse(s, out courseGNoOfGrades))
                {
                    txtstudentGRNoOfGrades.ResetText();
                    txtstudentGRNoOfGrades.AppendText(studentBlank);
                    txtstudentGRNoOfGrades.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void FileCreation()
        {
            string courseGId = cbstudentGRCourseId.Text;
            string courseGName = cbstudentGRCourseName.Text;
            string courseGStudentName = cbstudentGRName.Text;
            string courseGStudentId = cbstudentGRIdNo.Text;
            string courseGLecturer = cbstudentGRLecturer.Text;
            string courseGDescription = txtstudentGRComments.Text;

            int courseGNoOfGrades = Convert.ToInt32(txtstudentGRNoOfGrades.Text);

            int j = 0;
            var result = "";
            var courseGGrades = txtstudentGRGrades.Text
                                    .Split(',')
                                    .Select(m => Int32.Parse(m.Trim()))
                                    .ToArray();


            if (courseGGrades[j] >= 0 && courseGGrades[j] <= 100)
            {

                foreach (var item in courseGGrades)
                {
                    result += item + ",";

                }

            }


            DateTime dateTime = DateTime.Now;
            var currentDate = dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss tt");


            string filename = courseGStudentName + " - " + courseGName + " - " + "Report" + ".txt";
            var userDir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));


            string path =
                Path
                .Combine
                (Environment.GetFolderPath
                (Environment.SpecialFolder
                .MyDocuments),
                filename);

            
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine($"********  {courseGStudentName}  " +
                    $"Report ********\n\n");
                sw.WriteLine($"Course Id:  {courseGId} \n\r" +
                    $"Course Name : {courseGName} \n\r" +
                    $"Student Id:  {courseGStudentId} \n\r" +
                    $"Student Name: {courseGStudentName} \n\r" +
                    $"Lecturer: {courseGLecturer} \n\r" +
                    $"Comment: {courseGDescription} \n\r" +
                    $"Number of Grades: {courseGNoOfGrades} \n\r" +
                    $"Grades: {result}\n\r" +
                    $"Average: {Average}\n\r");


                sw.WriteLine("File was last modified : " + currentDate);
                sw.Close();

            }


            MessageBox.Show($"Your file has been updated on your local machine Filename : {filename} \n\r" +
                $"File Path : {path}\n\r");

        }



        public void StudentGradeSubmitButton()
        {
            try
            {
                string courseGId = cbstudentGRCourseId.Text;
                string courseGName = cbstudentGRCourseName.Text;
                string courseGStudentName = cbstudentGRName.Text;
                string courseGStudentId = cbstudentGRIdNo.Text;
                string courseGLecturer = cbstudentGRLecturer.Text;
                string courseGDescription = txtstudentGRComments.Text;

                int j = 0;
                var courseGGrades = txtstudentGRGrades.Text
                                    .Split(',')
                                    .Select(m => Int32.Parse(m.Trim()))
                                    .ToArray();

                int courseGNoOfGrades = Convert.ToInt32(txtstudentGRNoOfGrades.Text);

                //int courseGGrades = Convert.ToInt32(txtstudentGRGrades.Text);

                int maxNumber = 6;
                bool isValid = true;
                string errorMessage = "";


                if (string.IsNullOrWhiteSpace(courseGLecturer)
                    || string.IsNullOrWhiteSpace(courseGDescription))
                {
                    isValid = false;
                    errorMessage += "Error : Please enter missing Lecturer and/or Description.\n\r";
                    cbstudentGRLecturer.Focus();
                }

                if (courseGNoOfGrades >= maxNumber && courseGNoOfGrades != maxNumber)
                {
                    isValid = false;
                    errorMessage += $"Error : Maximum value exceed ({maxNumber}).\n\r";
                }


                if (courseGGrades[j] >= 0 && courseGGrades[j] <= 100)
                {
                    // true

                    for (int i = 0; i < courseGNoOfGrades; i++)
                    {
                        //courseGGrades;
                        sum += courseGGrades[j];
                        courseGGrades.ElementAtOrDefault(0);
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

                    if (isEditMode)
                    {
                        // Edit Code here


                        var result = "";

                        foreach (var item in courseGGrades)
                        {
                            //MessageBox.Show($"Your have earned. {item}%");
                            //MessageBox.Show($"{result}%");
                            result += item + ",";
                        }
                        List<int> gradesNumbersList = courseGGrades.ToList();



                        var id = int.Parse(lblSRId.Text);
                        var studentGradesRegistration = kCollege_DbEntities.
                            StudentGradesRegistrationRecords
                            .FirstOrDefault(q => q.id == id);

                        studentGradesRegistration.Coursename = cbstudentGRCourseName.Text;
                        studentGradesRegistration.Cid = cbstudentGRCourseId.Text;
                        studentGradesRegistration.Lecturername = cbstudentGRLecturer.Text;
                        studentGradesRegistration.Sname = cbstudentGRName.Text;
                        studentGradesRegistration.Sid = cbstudentGRIdNo.Text;
                        studentGradesRegistration.Scomments = txtstudentGRComments.Text;
                        //studentGradesRegistration.Sgrade = Convert.ToInt32(txtstudentGRGrades.Text);

                        studentGradesRegistration.Sgrade = gradesNumbersList.FirstOrDefault();
                        studentGradesRegistration.AverageGrade = Average;
                        studentGradesRegistration.NumOfGrades = courseGNoOfGrades;

                        FileCreation();
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

                        var result = "";

                        foreach (var item in courseGGrades)
                        {
                            //MessageBox.Show($"Your have earned. {item}%");
                            //MessageBox.Show($"{result}%");
                            result += item + ",";
                        }
                        List<int> gradesNumbersList = courseGGrades.ToList();

                        var studentGradesRegistration = new StudentGradesRegistrationRecord
                        {
                            Coursename = courseGName,
                            Cid = courseGId,
                            Lecturername = courseGLecturer,
                            Sname = courseGStudentName,
                            Sid = courseGStudentId,
                            Scomments = courseGDescription,
                            Sgrade = gradesNumbersList.FirstOrDefault(),
                            AverageGrade = Average,
                            NumOfGrades = courseGNoOfGrades
                        };



                        FileCreation();
                        kCollege_DbEntities.StudentGradesRegistrationRecords.Add(studentGradesRegistration);
                        


                        // Display output with Messagebox
                        MessageBox.Show($"Thanks for your submission.\n" +
                            $"Course Name : {courseGName} Course ID: {courseGId} \n\r" +
                            $"Lecturer : {courseGLecturer}\n\r" +
                            $"Student Name : {courseGStudentName}  Student Id: {courseGStudentId}\n\r" +
                            $"Description : {courseGDescription}\n\r" +
                            $"Grade : {result}");

                    }
                    kCollege_DbEntities.SaveChanges();
                    _manageGradesRecords.PopulateGrid();

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

        private void btnsaveGRGradesChanges_Click(object sender, EventArgs e)
        {
            StudentGradeSubmitButton();
        }

        private void btncancelGRGradesCancel_Click(object sender, EventArgs e)
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

        private void AddEditGrades_Load(object sender, EventArgs e)
        {
            // Select * from TypesOfCourses

            var sgradesrecords = kCollege_DbEntities.TypesOfCourses.ToList();
            cbstudentGRCourseId.DisplayMember = "Cid";
            cbstudentGRCourseId.ValueMember = "id";
            cbstudentGRCourseName.DisplayMember = "Name";
            cbstudentGRCourseName.ValueMember = "id";
            cbstudentGRCourseName.DataSource = sgradesrecords;
            cbstudentGRCourseId.DataSource = sgradesrecords;


            var sgradesrecordsname = kCollege_DbEntities.StudentRegistrationRecords
                .ToList();

            cbstudentGRIdNo.DisplayMember = "Sid";
            cbstudentGRIdNo.ValueMember = "id";
            cbstudentGRIdNo.DataSource = sgradesrecordsname;


            cbstudentGRName.DisplayMember = "Name";
            cbstudentGRName.ValueMember = "id";
            cbstudentGRName.DataSource = sgradesrecordsname;

            var sgradesteachersname = kCollege_DbEntities
                .TeacherRegistrationRecords
                .ToList();

            cbstudentGRLecturer.DisplayMember = "Name";
            cbstudentGRLecturer.ValueMember = "id";
            cbstudentGRLecturer.DataSource = sgradesteachersname;
        }

        
    }
}
