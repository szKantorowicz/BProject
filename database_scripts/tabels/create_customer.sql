use BProject_db

CREATE TABLE [dbo].[Customers] (
    [ID] [int] NOT NULL IDENTITY,
    [UserID] [int],
    [FirstName] [nvarchar](100),
    [LastName] [nvarchar](100),
    [UserName] [nvarchar](100) NOT NULL,
    [Email] [nvarchar](100) NOT NULL,
    [Phone] [nvarchar](20) NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY ([ID])
)
