USE [KCollege_Db]
GO

CREATE TABLE TypesOfProgramme(
	id int identity(1,1) primary key,
	name  nvarchar(100),
);


INSERT INTO [dbo].[TypesOfProgramme]
           ([name])
     VALUES
			('Associate Degree in Information Communication and Technology'),
            ('Bachelor Degree in Information  Communication and Technology');

CREATE  TABLE  TeacherRegistrationRecord(
	id int identity(1,1) primary key,
	name  nvarchar(50),
	phone nvarchar(10),
	email nvarchar(50),
	DateOfBirth  datetime,
	Tid nvarchar(15),
);

CREATE  TABLE  StudentRegistrationRecord(
	id int identity(1,1) primary key,
	Sid  nvarchar(15),
	Name  nvarchar(50),
	Phone nvarchar(10),
	Email nvarchar(50),
	TypeOfProgrammeid int,
);

GO


