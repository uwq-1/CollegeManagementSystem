namespace kUwi_WebForm
{
    public class Programs
    {
        private string ProgrammeName;
        private string ProgrammeCode;
        private Courses[] courses;

        Programme ( string ProgrammeName, string ProgrammeCode, Courses (string courseName, string courseCode)) //IDK if this works or how to put the object in 
        { 
            //checking which programme is select to bring back the courses associated with it
            if (ProgrammeCode == "ICT")
            {
               // ProgrammeName.courses = ICTcourses();
               //ProgrammeName.course.visible = true;
            }

            if (ProgrammeCode == "BCON")
            {
                //ProgrammeName.courses = BCONcourses();
            }

            if (ProgrammeCode == "Bmgt")
            {
                //ProgrammeCode.course = BMGTcourses();
            }
        }
    }
}