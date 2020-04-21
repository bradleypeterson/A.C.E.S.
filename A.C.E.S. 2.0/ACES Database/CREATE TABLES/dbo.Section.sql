USE [CS4450ACES]
GO

/****** Object: Table [dbo].[Section] Script Date: 4/20/2020 8:40:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Section] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Length]   NVARCHAR (MAX) NULL,
    [Semester] NVARCHAR (MAX) NULL,
    [Year]     INT            NOT NULL,
    [CourseID] INT            NOT NULL,
    [Archived] BIT            NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Section_CourseID]
    ON [dbo].[Section]([CourseID] ASC);


GO
ALTER TABLE [dbo].[Section]
    ADD CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED ([ID] ASC);


GO
ALTER TABLE [dbo].[Section]
    ADD CONSTRAINT [FK_Section_Course_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Course] ([ID]) ON DELETE CASCADE;


