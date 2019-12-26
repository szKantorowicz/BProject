use BProject_db

CREATE TABLE [dbo].[Users] 
(
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int] NOT NULL,
    [Name] [nvarchar](100) NOT NULL,
    [Email] [nvarchar](100) NOT NULL,
    [Password] [nvarchar](200) NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY ([ID])
)
