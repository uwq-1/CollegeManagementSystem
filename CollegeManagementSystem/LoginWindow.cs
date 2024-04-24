using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeManagementSystem.Database;

namespace CollegeManagementSystem
{
    public partial class LoginWindow : Form
    {

        private readonly KUniversityDbModel kCollege_DbEntities;

        public LoginWindow()
        {
            InitializeComponent();
            kCollege_DbEntities = new KUniversityDbModel();
        }

        
        private void btnloginSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();


                var username = txtloginUsername.Text.Trim();
                var password = txtloginPassword.Text;

                //var genericPassword = Utils.GenerateRandomPassword();

                var hashed_password = Utils.HashPassword(password);


                //var tuser = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.TeacherRegistrationRecord.Tid == username && q.password == password);
                //var user = kCollege_DbEntities.LoginRecords.FirstOrDefault(q => q.username == username && q.password == hashed_password);

                var user = kCollege_DbEntities
                    .LoginRecords
                    .FirstOrDefault(q => 
                    
                        q.username == username  
                        && 
                        q.password == hashed_password
                        &&
                        q.isActive == true

                    );

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                    
                }
                else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleShortName = role.Role.shortname;
                    //var login = 
                    var mainWindow = new MainWindow(this, role, user);
                    mainWindow.Show();
                    Hide();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again");
               
            }
        }
    }
}
