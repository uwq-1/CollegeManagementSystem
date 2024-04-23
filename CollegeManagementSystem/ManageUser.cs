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
    public partial class ManageUser : Form
    {
        private readonly KUniversityDbModel kCollege_DbEntities;
        private StudentWindow studentWindow;

        public ManageUser()
        {
            InitializeComponent();
            studentWindow = new StudentWindow();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void btnaddUser_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser
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

                // query database  for record
                var user = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.id == id);
                var genericPassword = studentWindow.studentDefaultPassword;
                var hashed_password = Utils.HashPassword(genericPassword);
                user.password = hashed_password;
                kCollege_DbEntities.SaveChanges();
                MessageBox.Show("Your password has been reset!");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }







    }
}
