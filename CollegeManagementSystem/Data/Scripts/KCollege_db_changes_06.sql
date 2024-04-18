-- Create a table to use as relationship to interact with the other tables.

USE [KCollege_Db]


CREATE TABLE  TypesOfCourses(
	id int identity(1,1) primary key,
	name  nvarchar(100),
);

-- Example from Sql Server Generated script  Add a Foreign Key.
--ALTER TABLE [dbo].[StudentRegistrationRecord]  WITH CHECK ADD  CONSTRAINT [FK_StudentRegistrationRecord_TypesOfProgramme] FOREIGN KEY([TypeOfProgrammeid])
--REFERENCES [dbo].[TypesOfProgramme] ([id])

ALTER TABLE [dbo].[StudentCoursesRegistrationRecord]  WITH CHECK ADD  CONSTRAINT [FK_StudentCoursesRegistrationRecord_TypesOfCourses] FOREIGN KEY([SCourseid])
REFERENCES  [dbo].[TypesOfCourses] ([id])

ALTER TABLE [dbo].[StudentCoursesRegistrationRecord] CHECK CONSTRAINT [FK_StudentCoursesRegistrationRecord_TypesOfCourses]

--ALTER TABLE  StudentCoursesRegistrationRecord
--ADD CONSTRAINT FK_StudentCoursesRegistrationRecord_TypesOfCourses
--FOREIGN KEY (SCourseid) REFERENCES TypesOfCourses(id);


-- Add  column in TypesOfCourses for  Course Id.
ALTER  TABLE   TypesOfCourses
ADD    Cid    nvarchar(25);


-- Enter test values in table.
INSERT INTO [dbo].[TypesOfCourses]
           ([name]
           ,[Cid])
     VALUES
			('Enterprise Application Development', 'CS244'),
            ('Introduction to Object Oriented Programming II', 'CS262'),
			('Pre-Calculus', 'MA124');

-- Delete the table 
--DROP TABLE  TypesOfCourses;
