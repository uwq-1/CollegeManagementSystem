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
        

        private ManageUser _manageUser;

        public AddUser(ManageUser manageUser)
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
            _manageUser = manageUser;
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
            
            try
            {
                var username = txtaddUserName.Text;
                var roleId = (int)cbRoles.SelectedValue;


                var genericPassword = Utils.GenerateRandomPassword();
                var password = Utils.HashPassword(genericPassword);


                var user = new LoginRecord
                {
                    //LoginRecord
                    username = username,
                    password = password,
                    isDefaultPassword = true,
                    isActive = true
                };


                var userid = user.id;
                var roleid = roleId;

                var userRoles = new UserRole
                {
                    userid = userid,
                    roleid = roleid
                };


                kCollege_DbEntities.UserRoles.Add(userRoles);

                kCollege_DbEntities.LoginRecords.Add(user);

                kCollege_DbEntities.SaveChanges();

                MessageBox.Show("User successfully created!\n\r" +
                    $"User default password is  {genericPassword} ");
                _manageUser.PopulateGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has Occured!");
            }


        }
    }
}
