USE [CS4450ACES]
GO

/****** Object: Table [dbo].[Submission] Script Date: 4/20/2020 8:41:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Submission] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [StudentID]    INT           NOT NULL,
    [AssignmentID] INT           NOT NULL,
    [Grade]        INT           NOT NULL,
    [Standing]     INT           NOT NULL,
    [DateTime]     DATETIME2 (7) NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Submission_AssignmentID]
    ON [dbo].[Submission]([AssignmentID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Submission_StudentID]
    ON [dbo].[Submission]([StudentID] ASC);


GO
ALTER TABLE [dbo].[Submission]
    ADD CONSTRAINT [PK_Submission] PRIMARY KEY CLUSTERED ([ID] ASC);


GO
ALTER TABLE [dbo].[Submission]
    ADD CONSTRAINT [FK_Submission_Student_StudentID] FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Student] ([ID]) ON DELETE CASCADE;


GO
ALTER TABLE [dbo].[Submission]
    ADD CONSTRAINT [FK_Submission_Assignment_AssignmentID] FOREIGN KEY ([AssignmentID]) REFERENCES [dbo].[Assignment] ([ID]) ON DELETE CASCADE;


