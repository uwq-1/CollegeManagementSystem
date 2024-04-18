namespace CollegeManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentCoursesRegistrationRecord")]
    public partial class StudentCoursesRegistrationRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentCoursesRegistrationRecord()
        {
            StudentGradesRegistrationRecords = new HashSet<StudentGradesRegistrationRecord>();
        }

        public int Id { get; set; }

        [StringLength(25)]
        public string Cid { get; set; }

        public int? SCourseid { get; set; }

        [StringLength(100)]
        public string Coursename { get; set; }

        [StringLength(50)]
        public string Lecturername { get; set; }

        [StringLength(200)]
        public string Sdescription { get; set; }

        [StringLength(100)]
        public string Ssemester { get; set; }

        public int? SCourseRecordsid { get; set; }

        public int? SGradesRecordsid { get; set; }

        public virtual StudentGradesRegistrationRecord StudentGradesRegistrationRecord { get; set; }

        public virtual TypesOfCours TypesOfCours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentGradesRegistrationRecord> StudentGradesRegistrationRecords { get; set; }
    }
}
