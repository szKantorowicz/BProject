use BProject_db

CREATE TABLE [dbo].[Status] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL,
    CONSTRAINT [PK_dbo.Status] PRIMARY KEY ([ID])
)