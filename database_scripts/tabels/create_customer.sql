use BProject_db

CREATE TABLE [dbo].[Customers] (
    [ID] [int] NOT NULL IDENTITY,
    [UserID] [int] NOT NULL,
    [FirstName] [nvarchar](100),
    [LastName] [nvarchar](100),
    [UserName] [nvarchar](100) NOT NULL,
    [Email] [nvarchar](100) NOT NULL,
    [Phone] [nvarchar](10),
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY ([ID])
)

