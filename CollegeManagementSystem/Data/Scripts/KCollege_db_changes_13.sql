USE [KCollege_Db]


-- Add new column to  the table 
ALTER  TABLE  StudentGradesRegistrationRecord
ADD   NumOfGrades   int;

-- Add new column to the table
ALTER  TABLE  StudentGradesRegistrationRecord
ADD   AverageGrade   int;