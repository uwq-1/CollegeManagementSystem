-- Create a table for login

USE [KCollege_Db]

CREATE TABLE LoginRecords(
	id int identity(1,1) primary key,
	username  nvarchar(50) NOT NULL, 
	password  nvarchar(100) NOT NULL,
);


--*****Updated Changes Made Here*******-------


-- Add new column to table 
ALTER TABLE  LoginRecords
ADD   isActive bit;


--Create a new table 
CREATE TABLE  Roles(
	id int identity(1,1) primary key,
	name  nvarchar(50), 
	shortname nvarchar(50), 
);



CREATE TABLE  UserRoles(
	id int identity(1,1) primary key,
	userid int,
	roleid int,
);


ALTER TABLE  UserRoles
ADD CONSTRAINT FK_UserRoles_LoginRecords
FOREIGN KEY (userid) REFERENCES LoginRecords(id);



ALTER TABLE  UserRoles
ADD CONSTRAINT FK_UserRoles_Roles
FOREIGN KEY (roleid) REFERENCES Roles(id);




--*****Updated Changes Made Here*******-------

ALTER TABLE  LoginRecords
ADD   studentid int, teacherid int;


ALTER TABLE  StudentRegistrationRecord
ADD  SdefaultPassword nvarchar(100);

ALTER TABLE  TeacherRegistrationRecord
ADD  TdefaultPassword nvarchar(100);

-- Create a foreign key to link the two tables.
ALTER TABLE  LoginRecords
ADD CONSTRAINT FK_LoginRecords_TeacherRegistrationRecord
FOREIGN KEY (teacherid) REFERENCES TeacherRegistrationRecord(id);


ALTER TABLE  LoginRecords
ADD CONSTRAINT FK_LoginRecords_StudentRegistrationRecord
FOREIGN KEY (studentid) REFERENCES StudentRegistrationRecord(id);