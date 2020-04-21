USE [CS4450ACES]
GO

/****** Object: Table [dbo].[Course] Script Date: 4/20/2020 8:40:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Course] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Archived] BIT            NOT NULL
);


