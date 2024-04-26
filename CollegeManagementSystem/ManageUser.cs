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
                //var hashed_password = Utils.HashPassword(genericSPassword);
                var hashed_password = Utils.DefaultHashedPassword(genericPassword);
                
                user.password = hashed_password;


                kCollege_DbEntities.SaveChanges();
                MessageBox.Show("Your password has been reset!");
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
                var userrecords = kCollege_DbEntities.UserRoles.FirstOrDefault(q => q.id == userid);

                DialogResult dr = MessageBox.Show($"Are you sure you want to DELETE THIS RECORD:" +
                    $" Name : {user.username}  \n\r ?",
                    "Delete Records", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    user.isActive = false;
                    kCollege_DbEntities.UserRoles.Remove(userrecords);
                    kCollege_DbEntities.LoginRecords.Remove(user);
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
                    STUNAME =  q.StudentRegistrationRecord.Name,
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
            gvUserSettingsRecords.Columns["STUNAME"].HeaderText = "Student name";
            gvUserSettingsRecords.Columns["LECTURER"].HeaderText = "LECTURER";
            
        }

        
    }
}
