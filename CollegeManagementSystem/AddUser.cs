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
    public partial class AddUser : Form
    {

        private readonly KUniversityDbModel kCollege_DbEntities;
        private StudentWindow studentWindow;
        public AddUser()
        {
            InitializeComponent();
            studentWindow = new StudentWindow();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = kCollege_DbEntities.Roles.ToList();
            cbRoles.DataSource = roles;
            cbRoles.ValueMember = "id";
            cbRoles.DisplayMember = "name";
        }

        private void btnaddUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnaddUserSubmit_Click(object sender, EventArgs e)
        {
            var username = txtaddUserName.Text;
            var roleId = (int)cbRoles.SelectedValue;
            var genericPassword = studentWindow.studentDefaultPassword;
            var password = Utils.HashPassword(genericPassword);
            var user = new LoginRecord
            {
                //LoginRecord
                username =  username,
                password =  password,
                isActive =  true
            };

            kCollege_DbEntities.LoginRecords.Add(user);
            kCollege_DbEntities.SaveChanges();

        }
    }
}
