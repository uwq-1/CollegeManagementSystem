
USE [KCollege_Db]

CREATE TABLE  TypesOfMajorSubjects(
	id int identity(1,1) primary key,
	name  nvarchar(100),
	
);

-- Add column to Table
ALTER TABLE TeacherRegistrationRecord
ADD  TypesOfMajorSubjectsid  int;


-- Create a foreign key to link two tables.
ALTER TABLE  TeacherRegistrationRecord
ADD CONSTRAINT FK_TeacherRegistrationRecord_TypesOfMajorSubjects
FOREIGN KEY (TypesOfMajorSubjectsid) REFERENCES TypesOfMajorSubjects(id);

-- Enter test values in table.
INSERT INTO [dbo].[TypesOfMajorSubjects]
           ([name])
     VALUES
			('Calculus Instructor'),
            ('Web Technology Instructor'),
			('Database Development Instructor'),
			('Network Instructor'),
			('Software Engineer Instructor');

-- Drop a foreign key
--ALTER TABLE TeacherRegistrationRecord
--DROP CONSTRAINT FK_TeacherRegistrationRecord_TypesOfMajorSubjects;

-- Delete a table
--DROP TABLE TypesOfMajorSubjects; 