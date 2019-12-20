use customer_db

CREATE TABLE [dbo].[Customers] (
    [ID] [int] NOT NULL IDENTITY,
    [UserID] [int],
    [FirstName] [nvarchar](max),
    [LastName] [nvarchar](max),
    [UserName] [nvarchar](max),
    [Email] [nvarchar](max),
    [Phone] [nvarchar](max),
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY ([ID])
)
