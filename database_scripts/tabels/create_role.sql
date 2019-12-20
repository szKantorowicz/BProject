use customer_db

CREATE TABLE [dbo].[Roles] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.Roles] PRIMARY KEY ([ID])
)