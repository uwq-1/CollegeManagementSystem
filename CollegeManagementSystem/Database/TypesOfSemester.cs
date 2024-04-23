namespace CollegeManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypesOfSemester")]
    public partial class TypesOfSemester
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypesOfSemester()
        {
            StudentCoursesRegistrationRecords = new HashSet<StudentCoursesRegistrationRecord>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentCoursesRegistrationRecord> StudentCoursesRegistrationRecords { get; set; }
    }
}
