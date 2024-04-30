using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kUwi_WebForm
{
    public class Grades
    {
        private Courses[] courses;
        private Student student;// Ask vhas if both student name and lecturer name
        private Lecturer lecturer;// work with this
        private string courseId; //ask vhas if this should be an array?
        private int studentId_Num;
        private string comments;
        private float grade;
        private Programs [] program;

        public Courses[] Courses
        {
            get { return courses; } //get method(field) 
            set { courses = value; } // set method for the field
        }

        public Student Student
        {
            get { return student; }
            protected set { }
        }

        public Lecturer Lecturer
        {
            get { return lecturer; }
            protected set { }
        }

        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public int StudentId_Num
        {
            get { return studentId_Num; }
            protected set { studentId_Num = value; }
        }
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        public float Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public Grades ()
        {

        }
        public Student GetStudent(PersonName name)
        {
            return student;
        }
        public void updateGrade()
        {

        }
        public void updateComments()
        { 
        }

        public Courses[] GetCourses()
        {
            return courses;
        }
        public Programs[] GetProgram()
        {
            return program;
        }

}

}