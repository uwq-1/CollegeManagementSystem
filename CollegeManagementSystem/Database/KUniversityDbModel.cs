using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CollegeManagementSystem.Database
{
    public partial class KUniversityDbModel : DbContext
    {
        public KUniversityDbModel()
            : base("name=KUniversityDbModel")
        {
        }

        public virtual DbSet<LoginRecord> LoginRecords { get; set; }
        public virtual DbSet<StudentCoursesRegistrationRecord> StudentCoursesRegistrationRecords { get; set; }
        public virtual DbSet<StudentGradesRegistrationRecord> StudentGradesRegistrationRecords { get; set; }
        public virtual DbSet<StudentRegistrationRecord> StudentRegistrationRecords { get; set; }
        public virtual DbSet<TeacherRegistrationRecord> TeacherRegistrationRecords { get; set; }
        public virtual DbSet<TypesOfCours> TypesOfCourses { get; set; }
        public virtual DbSet<TypesOfGrade> TypesOfGrades { get; set; }
        public virtual DbSet<TypesOfMajorSubject> TypesOfMajorSubjects { get; set; }
        public virtual DbSet<TypesOfProgramme> TypesOfProgrammes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCoursesRegistrationRecord>()
                .HasMany(e => e.StudentGradesRegistrationRecords)
                .WithOptional(e => e.StudentCoursesRegistrationRecord)
                .HasForeignKey(e => e.SCourseRecordsid);

            modelBuilder.Entity<StudentGradesRegistrationRecord>()
                .HasMany(e => e.StudentCoursesRegistrationRecords)
                .WithOptional(e => e.StudentGradesRegistrationRecord)
                .HasForeignKey(e => e.SGradesRecordsid);

            modelBuilder.Entity<StudentRegistrationRecord>()
                .HasMany(e => e.LoginRecords)
                .WithOptional(e => e.StudentRegistrationRecord)
                .HasForeignKey(e => e.SRecords);

            modelBuilder.Entity<TeacherRegistrationRecord>()
                .HasMany(e => e.LoginRecords)
                .WithOptional(e => e.TeacherRegistrationRecord)
                .HasForeignKey(e => e.TRecords);

            modelBuilder.Entity<TypesOfCours>()
                .HasMany(e => e.StudentCoursesRegistrationRecords)
                .WithOptional(e => e.TypesOfCours)
                .HasForeignKey(e => e.SCourseid);

            modelBuilder.Entity<TypesOfGrade>()
                .HasMany(e => e.StudentGradesRegistrationRecords)
                .WithOptional(e => e.TypesOfGrade)
                .HasForeignKey(e => e.SGradesid);

            modelBuilder.Entity<TypesOfMajorSubject>()
                .HasMany(e => e.TeacherRegistrationRecords)
                .WithOptional(e => e.TypesOfMajorSubject)
                .HasForeignKey(e => e.TypesOfMajorSubjectsid);

            modelBuilder.Entity<TypesOfProgramme>()
                .HasMany(e => e.StudentRegistrationRecords)
                .WithOptional(e => e.TypesOfProgramme)
                .HasForeignKey(e => e.TypeOfProgrammeid);
        }
    }
}
