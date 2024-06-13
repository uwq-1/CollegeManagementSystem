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

                // Get users username and password 
                // Hash the password after being captured.
                var username = txtloginUsername.Text.Trim();
                var password = txtloginPassword.Text;
                var hashed_password = Utils.HashPassword(password);
                

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
                    
                    var mainWindow = new MainWindow(this, role, user);
                    mainWindow.Show();
                    Hide();



                    if (roleShortName == "student")
                    {
                        MessageBox.Show($"You have successfully login.\n\r" +
                            $" Welcome back {user.StudentRegistrationRecord.Name}");
                    }

                    if (roleShortName == "teacher")
                    {
                        MessageBox.Show($"You have successfully login.\n\r" +
                            $" Welcome back {user.TeacherRegistrationRecord.name}");
                    }

                    if (roleShortName != "student" && roleShortName != "teacher")
                    {
                        // General Message
                        MessageBox.Show($"You have successfully login.");
                    }


                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again");
               
            }
        }
    }
}
