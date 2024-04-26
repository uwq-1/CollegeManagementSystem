using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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


        public Lecturer(PersonName name, string position, string emailAddress)//constructor
        {

        }
        public void updatePosition(string position)
        {

        }
        public void updateCourse()
        {

        }
        public Courses[] getCourses()
        {
            return courses;
        }


    
    }
}