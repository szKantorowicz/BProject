use BProject_db

CREATE TABLE [dbo].[Categories] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL,
    [Description] [nvarchar](1000),
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY ([ID])
)