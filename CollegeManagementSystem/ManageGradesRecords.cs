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

namespace CollegeManagementSystem
{
    public partial class ManageGradesRecords : Form
    {

        public string _roleName;

        public UserRole _role = null;


        private readonly KUniversityDbModel kCollege_DbEntities;
        
        public ManageGradesRecords()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        public ManageGradesRecords(UserRole role = null)
        {
            InitializeComponent();
            _role = role;
            _roleName = role.LoginRecord.UserRoles.FirstOrDefault().Role.shortname;
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void ManageStudentsRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();

                if (_roleName != "admin")
                {

                    // Add Records
                    btnaddSRecords.Hide();
                    btnaddSRecords.Visible = false;
                    btnaddSRecords.Enabled = false;

                    // Edit Records
                    btneditSRecords.Hide();
                    btneditSRecords.Visible = false;
                    btneditSRecords.Enabled = false;

                    // Delete Records
                    btndeleteSRecords.Hide();
                    btndeleteSRecords.Visible = false;
                    btndeleteSRecords.Enabled = false;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void btnaddSRecords_Click(object sender, EventArgs e)
        {
            var addEditGradesRecords = new AddEditGrades(this)
            {
                MdiParent = this.MdiParent
            };
            addEditGradesRecords.Show();
        }

        private void btneditSRecords_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvGradesRecords.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var srecords = kCollege_DbEntities.StudentGradesRegistrationRecords.FirstOrDefault(q => q.id == id);

                // launch AddEditGradesRecords window  with data 
                var addEditGradesRecords = new AddEditGrades(srecords, this);
                addEditGradesRecords.MdiParent = this.MdiParent;
                addEditGradesRecords.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                
            }

            
        }

        private void btndeleteSRecords_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvGradesRecords.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var srecords = kCollege_DbEntities.StudentGradesRegistrationRecords.FirstOrDefault(q => q.id == id);


                DialogResult dr = MessageBox.Show($"Are you sure you want to DELETE THIS RECORD: STUDENT NAME : {srecords.Sname}\n\r ?",
                    "Delete Records", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    // delete students records from database
                    kCollege_DbEntities.StudentGradesRegistrationRecords.Remove(srecords);
                    kCollege_DbEntities.SaveChanges();
                }
                PopulateGrid();
                //gvStudentsRecords.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error : {ex.Message}");
            }
            
        }


        public void PopulateGrid() 
        {
            var sdatainfo = kCollege_DbEntities.StudentGradesRegistrationRecords
                .Select(q => new {
                    ID = q.id,
                    SID = q.Sid,
                    STUNAME = q.Sname,
                    CourseNAME = q.Coursename,
                    CourseID = q.Cid,
                    LECTURER = q.Lecturername,
                    COMMENTS = q.Scomments,
                    GRADE = q.Sgrade

                })
                .ToList();



            gvGradesRecords.DataSource = sdatainfo;
            //gvStudentsRecords.Columns[0].HeaderText = "ID";
            gvGradesRecords.Columns[0].Visible = false;
            gvGradesRecords.Columns[1].HeaderText = "S-ID";
            gvGradesRecords.Columns[2].HeaderText = "STUDENT NAME";
            gvGradesRecords.Columns[3].HeaderText = "COURSE NAME";
            gvGradesRecords.Columns[4].HeaderText = "COURSE ID";
            gvGradesRecords.Columns[5].HeaderText = "LECTURER";
            gvGradesRecords.Columns[6].HeaderText = "DESCRIPTION";
            gvGradesRecords.Columns[7].HeaderText = "GRADE";
        }


        /*private void btnstudentRecordsRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }*/
    }
}
