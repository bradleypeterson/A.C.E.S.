USE [CS4450ACES]
GO

/****** Object: Table [dbo].[SectionStudent] Script Date: 4/20/2020 8:41:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SectionStudent] (
    [ID]        INT IDENTITY (1, 1) NOT NULL,
    [SectionID] INT NOT NULL,
    [StudentID] INT NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_SectionStudent_SectionID]
    ON [dbo].[SectionStudent]([SectionID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_SectionStudent_StudentID]
    ON [dbo].[SectionStudent]([StudentID] ASC);


GO
ALTER TABLE [dbo].[SectionStudent]
    ADD CONSTRAINT [PK_SectionStudent] PRIMARY KEY CLUSTERED ([ID] ASC);


GO
ALTER TABLE [dbo].[SectionStudent]
    ADD CONSTRAINT [FK_SectionStudent_Student_StudentID] FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Student] ([ID]) ON DELETE CASCADE;


GO
ALTER TABLE [dbo].[SectionStudent]
    ADD CONSTRAINT [FK_SectionStudent_Section_SectionID] FOREIGN KEY ([SectionID]) REFERENCES [dbo].[Section] ([ID]) ON DELETE CASCADE;


