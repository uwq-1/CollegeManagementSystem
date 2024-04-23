-- Create a new table for semester names

USE [KCollege_Db]

CREATE TABLE TypesOfSemester(
	id int identity(1,1) primary key,
	name  nvarchar(100), 
	
);

ALTER TABLE  StudentCoursesRegistrationRecord
ADD   TypesOfSemesterid int;


-- Create a foreign key to link the two tables.
ALTER TABLE  StudentCoursesRegistrationRecord
ADD CONSTRAINT FK_StudentCoursesRegistrationRecord_TypesOfSemester
FOREIGN KEY (TypesOfSemesterid) REFERENCES TypesOfSemester(id);


-- Input values in TypesOfSemester table
INSERT INTO [dbo].[TypesOfSemester]
			(name)
	VALUES
			('Semester 1'),
			('Semester 2'),
			('Semester 3'),
			('Semester 4');
