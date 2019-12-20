use customer_db

CREATE TABLE [dbo].[Categories] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Description] [nvarchar](max),
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY ([ID])
)
