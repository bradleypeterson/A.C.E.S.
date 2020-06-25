USE [CS4450ACES]
GO

SET IDENTITY_INSERT [dbo].[Assignment] ON
INSERT INTO [dbo].[Assignment] ([ID], [Name], [Files], [UnitTesters], [CourseID], [Grade], [Standing], [Archived]) VALUES (1, N'Assignment1', N'', N'', 1, 0, 2, 0)
INSERT INTO [dbo].[Assignment] ([ID], [Name], [Files], [UnitTesters], [CourseID], [Grade], [Standing], [Archived]) VALUES (2, N'Assignment 2', N'', N'', 1, 0, 2, 0)
SET IDENTITY_INSERT [dbo].[Assignment] OFF

SET IDENTITY_INSERT [dbo].[Course] ON
INSERT INTO [dbo].[Course] ([ID], [Name], [Archived]) VALUES (1, N'CS 2420', 0)
INSERT INTO [dbo].[Course] ([ID], [Name], [Archived]) VALUES (2, N'Course 1', 0)
INSERT INTO [dbo].[Course] ([ID], [Name], [Archived]) VALUES (3, N'asd', 0)
SET IDENTITY_INSERT [dbo].[Course] OFF

SET IDENTITY_INSERT [dbo].[Section] ON
INSERT INTO [dbo].[Section] ([ID], [Name], [Length], [Semester], [Year], [CourseID], [Archived]) VALUES (1, N'Test Section', N'2nd Block', N'Summer', 2020, 1, 0)
INSERT INTO [dbo].[Section] ([ID], [Name], [Length], [Semester], [Year], [CourseID], [Archived]) VALUES (2, N'Cool Section', N'1st Block', N'Fall', 0, 1, 0)
INSERT INTO [dbo].[Section] ([ID], [Name], [Length], [Semester], [Year], [CourseID], [Archived]) VALUES (3, N'Cooler Section', NULL, N'Spring', 2020, 2, 0)
SET IDENTITY_INSERT [dbo].[Section] OFF

SET IDENTITY_INSERT [dbo].[SectionStudent] ON
INSERT INTO [dbo].[SectionStudent] ([ID], [SectionID], [StudentID]) VALUES (1, 1, 1)
INSERT INTO [dbo].[SectionStudent] ([ID], [SectionID], [StudentID]) VALUES (2, 2, 1)
INSERT INTO [dbo].[SectionStudent] ([ID], [SectionID], [StudentID]) VALUES (3, 3, 1)
INSERT INTO [dbo].[SectionStudent] ([ID], [SectionID], [StudentID]) VALUES (4, 1, 2)
INSERT INTO [dbo].[SectionStudent] ([ID], [SectionID], [StudentID]) VALUES (5, 1, 3)
SET IDENTITY_INSERT [dbo].[SectionStudent] OFF

SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([ID], [Name], [Email], [Archived], [Standing]) VALUES (1, N'Test Student 2', N'test@test.com', 0, 0)
INSERT INTO [dbo].[Student] ([ID], [Name], [Email], [Archived], [Standing]) VALUES (2, N'Robert Pickard', N'robertpickard@mail.weber.edu', 0, 0)
INSERT INTO [dbo].[Student] ([ID], [Name], [Email], [Archived], [Standing]) VALUES (3, N'Robert', N'Robert@robert.com', 0, 0)
INSERT INTO [dbo].[Student] ([ID], [Name], [Email], [Archived], [Standing]) VALUES (4, N'RJP', N'RJP@test.com', 0, 0)
INSERT INTO [dbo].[Student] ([ID], [Name], [Email], [Archived], [Standing]) VALUES (5, N'Test Student 2', N'test@test.com', 0, 0)
INSERT INTO [dbo].[Student] ([ID], [Name], [Email], [Archived], [Standing]) VALUES (6, N'Test Student 2', N'test@test.com', 0, 0)
INSERT INTO [dbo].[Student] ([ID], [Name], [Email], [Archived], [Standing]) VALUES (7, N'asd', N'asd', 0, 0)
SET IDENTITY_INSERT [dbo].[Student] OFF

SET IDENTITY_INSERT [dbo].[StudentAssignment] ON
INSERT INTO [dbo].[StudentAssignment] ([ID], [StudentID], [AssignmentID], [AverageStanding], [OverrideStanding]) VALUES (1, 1, 1, 0, 1)
SET IDENTITY_INSERT [dbo].[StudentAssignment] OFF

SET IDENTITY_INSERT [dbo].[Submission] ON
INSERT INTO [dbo].[Submission] ([ID], [StudentID], [AssignmentID], [Grade], [Standing], [DateTime]) VALUES (1, 1, 1, 8, 0, N'2020-04-08 00:00:00')
INSERT INTO [dbo].[Submission] ([ID], [StudentID], [AssignmentID], [Grade], [Standing], [DateTime]) VALUES (3, 1, 1, 9, 1, N'2020-04-09 00:00:00')
INSERT INTO [dbo].[Submission] ([ID], [StudentID], [AssignmentID], [Grade], [Standing], [DateTime]) VALUES (5, 1, 2, 50, 2, N'2020-04-07 00:00:00')
INSERT INTO [dbo].[Submission] ([ID], [StudentID], [AssignmentID], [Grade], [Standing], [DateTime]) VALUES (6, 2, 1, 43, 0, N'2020-04-03 00:00:00')
INSERT INTO [dbo].[Submission] ([ID], [StudentID], [AssignmentID], [Grade], [Standing], [DateTime]) VALUES (7, 1, 1, 70, 2, N'2020-04-09 02:00:00')
SET IDENTITY_INSERT [dbo].[Submission] OFF
