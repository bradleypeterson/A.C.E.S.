SET IDENTITY_INSERT [dbo].[Section] ON
INSERT INTO [dbo].[Section] ([ID], [Name], [Length], [Semester], [Year], [CourseID], [Archived]) VALUES (1, N'Test Section', N'2nd Block', N'Summer', 2020, 1, 0)
INSERT INTO [dbo].[Section] ([ID], [Name], [Length], [Semester], [Year], [CourseID], [Archived]) VALUES (2, N'Cool Section', N'1st Block', N'Fall', 0, 1, 0)
INSERT INTO [dbo].[Section] ([ID], [Name], [Length], [Semester], [Year], [CourseID], [Archived]) VALUES (3, N'Cooler Section', NULL, N'Spring', 2020, 2, 0)
SET IDENTITY_INSERT [dbo].[Section] OFF
