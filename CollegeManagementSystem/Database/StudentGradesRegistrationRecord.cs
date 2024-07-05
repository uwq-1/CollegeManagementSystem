namespace CollegeManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentGradesRegistrationRecord")]
    public partial class StudentGradesRegistrationRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentGradesRegistrationRecord()
        {
            StudentCoursesRegistrationRecords = new HashSet<StudentCoursesRegistrationRecord>();
        }

        public int id { get; set; }

        [StringLength(25)]
        public string Cid { get; set; }

        [StringLength(100)]
        public string Coursename { get; set; }

        [StringLength(25)]
        public string Sid { get; set; }

        [StringLength(50)]
        public string Sname { get; set; }

        [StringLength(50)]
        public string Lecturername { get; set; }

        [StringLength(200)]
        public string Scomments { get; set; }

        public int? Sgrade { get; set; }

        public int? SGradesid { get; set; }

        public int? SCourseRecordsid { get; set; }

        public int? SGradesRecordsid { get; set; }

        public int? NumOfGrades { get; set; }

        public int? AverageGrade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentCoursesRegistrationRecord> StudentCoursesRegistrationRecords { get; set; }

        public virtual StudentCoursesRegistrationRecord StudentCoursesRegistrationRecord { get; set; }

        public virtual TypesOfGrade TypesOfGrade { get; set; }
    }
}
