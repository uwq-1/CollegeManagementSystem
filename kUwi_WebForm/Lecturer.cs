using Microsoft.Ajax.Utilities;

namespace kUwi_WebForm
{
    public class Lecturer
    {
        private string position; //field
        private PersonName name;
        private Courses[] courses;
        private int id_Num;
        private string emailAddress;
        private string loginName;
        private string password;

        public string Position  //Property
        {
            get { return position; } //get method(field) 
            set { position = value; } // set method for the field
        }

        public int Id_num
        {
            get { return id_Num; }
            protected set { }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return $"{name.FirstName} {name.LastName}"; }
            protected set { }
        }
        public Lecturer(PersonName name, string position, string emailAddress)//constructor 
        {
            if (name != null && position != null && emailAddress.IsNullOrWhiteSpace())
            {
                this.name = name;
                this.position = position;
                this.emailAddress = emailAddress;
            }
        }
        public void UpdatePosition(string position)
        {
            //if the positions previous held has changed then create new position
            if (!string.IsNullOrWhiteSpace(position) && this.position != position) 
            {
                this.position = position;
            }
        }
        public void UpdateCourse( Courses [] selectedCourses)
        {
            
            if (selectedCourses != null) 
            {
                courses = selectedCourses;
            }
        }
        public Courses[] GetCourses()
        {
            return courses;
        }
    }
}