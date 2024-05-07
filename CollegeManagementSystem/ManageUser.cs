using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public partial class ManageUser : Form
    {
        private readonly KUniversityDbModel kCollege_DbEntities;
        

        public ManageUser()
        {
            InitializeComponent();
            
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void btnaddUser_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this)
                {
                    MdiParent = this.MdiParent
                };
                addUser.Show();
            }

            
        }

        private void btnresetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvUserSettingsRecords.SelectedRows[0].Cells["id"].Value;
                
                // Getting random password
                var defaultPassword = Utils.GenerateRandomPassword();
                // query database  for record
                var user = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.id == id);
                var genericPassword = defaultPassword;
                var hashed_password = Utils.DefaultHashedPassword(genericPassword);
                
                user.password = hashed_password;

                // Set user isDefaultPassword Status 
                user.isDefaultPassword = true;

                kCollege_DbEntities.SaveChanges();
                MessageBox.Show($"Your password has been reset!\n\r" +
                    $"Your new password is :  {genericPassword}");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void btndeativateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvUserSettingsRecords.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var user = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.id == id);
                // if (user.isActive == true)
                //     user.isActive == false;
                // else
                //      user.isActive == true;
                user.isActive = user.isActive == true ? false: true;
                kCollege_DbEntities.SaveChanges();
                MessageBox.Show("Active Status has changed!");
                PopulateGrid();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }


        private void btndeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvUserSettingsRecords.SelectedRows[0].Cells["id"].Value;
                var userid = (int)gvUserSettingsRecords.SelectedRows[0].Cells["id"].Value;

                // query database  for record
                var user = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.id == id);
                var userrecords = kCollege_DbEntities.UserRoles.FirstOrDefault(q => q.userid == userid);

                PopulateStudentRecords();
                var studentrecords = kCollege_DbEntities.StudentRegistrationRecords.FirstOrDefault(q => q.id == user.studentid);
                PopulateTeacherRecords();
                var teacherrecords = kCollege_DbEntities.TeacherRegistrationRecords.FirstOrDefault(q => q.id == user.teacherid);

                DialogResult dr = MessageBox.Show($"Are you sure you want to DELETE THIS RECORD:" +
                    $" Name : {user.username}  \n\r ?",
                    "Delete Records", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    user.isActive = false;
                    kCollege_DbEntities.UserRoles.Remove(userrecords);
                    kCollege_DbEntities.LoginRecords.Remove(user);


                    if (studentrecords != null)
                    {
                        kCollege_DbEntities.StudentRegistrationRecords.Remove(studentrecords);
                        kCollege_DbEntities.SaveChanges();
                    }

                    if (teacherrecords != null)
                    {
                        kCollege_DbEntities.TeacherRegistrationRecords.Remove(teacherrecords);
                        kCollege_DbEntities.SaveChanges();
                    }

                    kCollege_DbEntities.SaveChanges();
                    MessageBox.Show("User records has  been deleted!");
                }

                PopulateGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured!");
                
            }
        }


        private void ManageUser_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        public void PopulateStudentRecords()
        {
            var records = kCollege_DbEntities
                .StudentRegistrationRecords
                .Select(q => new
                {
                    ID = q.id,
                    SID = q.Sid,
                    NAME = q.Name,
                    PROGRAMME = q.TypesOfProgramme.name,
                    Tution = q.Stution,
                    EMAIL = q.Email,
                    TEL = q.Phone,
                    DOB = q.DateOfBirth
                }).ToList();
        }


        public void PopulateTeacherRecords()
        {
            var records = kCollege_DbEntities
                .TeacherRegistrationRecords
                .Select(q => new
                {
                    ID = q.id,
                    TID = q.Tid,
                    NAME = q.name,
                    MAJORSUBJECT = q.TypesOfMajorSubject.name,
                    EMAIL = q.email,
                    TEL = q.phone,
                    DOB = q.DateOfBirth
                }).ToList();
        }

        public void PopulateGrid()
        {
            var userinfo = kCollege_DbEntities
                .LoginRecords
                .Select(q => new {
                    ID = q.id,
                    USERNAME = q.username,
                    USERID =   q.UserRoles.FirstOrDefault().userid,
                    ROLE =     q.UserRoles.FirstOrDefault().Role.name,
                    ISDEFAULTPASSWORD = q.isDefaultPassword,
                    STATUS =   q.isActive,
                    STUID =    q.studentid,
                    STUNAME =  q.StudentRegistrationRecord.Name,
                    LECTURERID = q.teacherid,
                    LECTURER = q.TeacherRegistrationRecord.name
                })
                .ToList();

           

            gvUserSettingsRecords.DataSource = userinfo;
            //gvUserSettingsRecords.Columns[0].HeaderText = "ID";
            gvUserSettingsRecords.Columns["ID"].Visible = false;
            gvUserSettingsRecords.Columns["USERNAME"].HeaderText = "Username";
            gvUserSettingsRecords.Columns["USERID"].HeaderText = "Userid";
            gvUserSettingsRecords.Columns["ROLE"].HeaderText = "Role";
            gvUserSettingsRecords.Columns["ISDEFAULTPASSWORD"].HeaderText = "Default Password";
            gvUserSettingsRecords.Columns["STATUS"].HeaderText = "Status";
            gvUserSettingsRecords.Columns["STUID"].HeaderText = "Student id";
            gvUserSettingsRecords.Columns["STUNAME"].HeaderText = "Student name";
            gvUserSettingsRecords.Columns["LECTURERID"].HeaderText = "Lecturer id";
            gvUserSettingsRecords.Columns["LECTURER"].HeaderText = "LECTURER";
            
        }

        
    }
}
