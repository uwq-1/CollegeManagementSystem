USE [KCollege_Db]

-- Changed data type 
ALTER  TABLE   StudentGradesRegistrationRecord
ALTER  COLUMN  Sgrade  int;

-- Add new columns to two tables 
ALTER  TABLE  StudentCoursesRegistrationRecord
ADD   SCourseRecordsid   int, SGradesRecordsid   int;

ALTER  TABLE  StudentGradesRegistrationRecord
ADD   SCourseRecordsid   int, SGradesRecordsid int;
  

-- Create a foreign key to link the two tables.
ALTER TABLE  StudentGradesRegistrationRecord
ADD CONSTRAINT FK_StudentGradesRegistrationRecord_StudentCoursesRegistrationRecord
FOREIGN KEY (SCourseRecordsid) REFERENCES StudentCoursesRegistrationRecord(Id);


ALTER TABLE  StudentCoursesRegistrationRecord
ADD CONSTRAINT FK_StudentCoursesRegistrationRecord_StudentGradesRegistrationRecord
FOREIGN KEY (SGradesRecordsid) REFERENCES StudentGradesRegistrationRecord(id);