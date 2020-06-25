USE [CS4450ACES]
GO

/****** Object: Table [dbo].[StudentAssignment] Script Date: 4/20/2020 8:41:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentAssignment] (
    [ID]               INT IDENTITY (1, 1) NOT NULL,
    [StudentID]        INT NOT NULL,
    [AssignmentID]     INT NOT NULL,
    [AverageStanding]  INT NOT NULL,
    [OverrideStanding] INT NOT NULL
);


