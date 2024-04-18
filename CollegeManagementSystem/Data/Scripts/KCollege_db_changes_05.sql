USE [KCollege_Db]

-- Create two primary tables 
CREATE TABLE  StudentCoursesRegistrationRecord(
	Id int identity(1,1) primary key,
	Cid  nvarchar(25),
	SCourseid int,
	Coursename  nvarchar(100),
	Lecturername nvarchar(50),
	Sdescription nvarchar(200),
	Ssemester nvarchar(100),
	
);


CREATE TABLE  StudentGradesRegistrationRecord(
	id int identity(1,1) primary key,
	Cid  nvarchar(25),
	Coursename  nvarchar(100),
	Sid  nvarchar(25),
	Sname nvarchar(50),
	Lecturername nvarchar(50),
	Scomments nvarchar(200),
	Sgrade nvarchar(85),
	SGradesid int,
);

