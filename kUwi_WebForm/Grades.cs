using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kUwi_WebForm
{
    public class Grades
    {
        private Courses[] courses;
        private StudentName studentName;// Ask vhas if both student name and lecturer name
        private LecturerName lecturerName;// work with this
        private string CourseId; //ask vhas if this should be an array?
        private int StudentId_Num;
        private string Comments;
        private float Grade;

        public Courses[] courses
        {
            get { return courses; } //get method(field) 
            set { courses = value; } // set method for the field
        }

        public string StudentName
        {
            get { return i; }
            protected set { }
        }

        public string LecturerName
        {
            get { return; }
            set { = value; }
        }

        public string CourseId
        {
            get { return CourseId; }
            set { CourseId = value; }
        }
        public int StudentId_Num
        {
            get { return StudentId_Num; }
            protected set { StudentId_Num = value; }
        }
        public string Comments
        {
            get { return Comments; }
            set { Comments = value; }
        }
        public float Grade
        {
            get { return Grade; }
            set { Grade = value; }
        }

        public StudentName(PersonName name)
        {

        }
        public void updateGrade()
        {

        }
        public void updateComments()

    public Courses[] getCourses()
        {

        }
        public Program[] GetProgram()

}

}