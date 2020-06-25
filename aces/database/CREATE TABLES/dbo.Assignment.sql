USE [CS4450ACES]
GO

/****** Object: Table [dbo].[Assignment] Script Date: 4/20/2020 8:35:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Assignment] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Files]       NVARCHAR (MAX) NULL,
    [UnitTesters] NVARCHAR (MAX) NULL,
    [CourseID]    INT            NOT NULL,
    [Grade]       INT            NOT NULL,
    [Standing]    INT            NOT NULL,
    [Archived]    BIT            NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Assignment_CourseID]
    ON [dbo].[Assignment]([CourseID] ASC);


GO
ALTER TABLE [dbo].[Assignment]
    ADD CONSTRAINT [PK_Assignment] PRIMARY KEY CLUSTERED ([ID] ASC);


GO
ALTER TABLE [dbo].[Assignment]
    ADD CONSTRAINT [FK_Assignment_Course_CourseID] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Course] ([ID]) ON DELETE CASCADE;


