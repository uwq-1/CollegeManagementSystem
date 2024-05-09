using System;

namespace kUwi_WebForm
{
    public partial class KIWA : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetStartedButton_Click(object sender, EventArgs e)
        {
            //Redirect user to the Login/Registration Screen 
            Server.Transfer("Login_RegistrationScreen.aspx");
        }
    }
}