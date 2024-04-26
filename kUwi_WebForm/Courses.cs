using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kUwi_WebForm
{
    public class Courses
    {
        private string CourseName;
        private string CourseId;
        private string Lecturer;
        private string Description;
        private int Semester;

        public string CourseName
        {
            get { return CourseName; }
            set { CourseName = value; }
        }
        public string CourseId
        {
            get { return CourseId; }
            set { CourseId = value}
        }
        public string Lecturer
        {
            get { return Lecturer; }
            set { Lecturer = value:}
        }
        public string Description
        {
            get { return Description; }
            set { Description = value; }
        }
        public int Semester
        {
            get { return Semester; }
            set { Semester = value; }
        }
    }

}