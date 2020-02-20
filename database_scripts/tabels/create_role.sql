use BProject_db

CREATE TABLE [dbo].[Roles] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Roles] PRIMARY KEY ([ID])
)