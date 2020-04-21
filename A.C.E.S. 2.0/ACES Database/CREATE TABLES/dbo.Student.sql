USE [CS4450ACES]
GO

/****** Object: Table [dbo].[Student] Script Date: 4/20/2020 8:41:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Email]    NVARCHAR (MAX) NULL,
    [Archived] BIT            NOT NULL,
    [Standing] INT            NOT NULL
);


