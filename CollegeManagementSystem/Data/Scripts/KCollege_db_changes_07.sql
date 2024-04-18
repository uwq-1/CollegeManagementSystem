USE [KCollege_Db]

CREATE TABLE  TypesOfGrades(
	id int identity(1,1) primary key,
	name  nvarchar(100),
);


-- Create a foreign key to link the two tables.
ALTER TABLE  StudentGradesRegistrationRecord
ADD CONSTRAINT FK_StudentGradesRegistrationRecord_TypesOfGrades
FOREIGN KEY (SGradesid) REFERENCES TypesOfGrades(id);