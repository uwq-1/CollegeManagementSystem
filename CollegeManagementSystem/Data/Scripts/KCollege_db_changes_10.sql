-- Create a table for login

USE [KCollege_Db]

CREATE TABLE LoginRecords(
	id int identity(1,1) primary key,
	username  nvarchar(50) NOT NULL, 
	password  nvarchar(100) NOT NULL,
);

ALTER TABLE  LoginRecords
ADD   SRecords int, TRecords int;


-- Create a foreign key to link the two tables.
ALTER TABLE  LoginRecords
ADD CONSTRAINT FK_LoginRecords_TeacherRegistrationRecord
FOREIGN KEY (TRecords) REFERENCES TeacherRegistrationRecord(id);


ALTER TABLE  LoginRecords
ADD CONSTRAINT FK_LoginRecords_StudentRegistrationRecord
FOREIGN KEY (SRecords) REFERENCES StudentRegistrationRecord(id);