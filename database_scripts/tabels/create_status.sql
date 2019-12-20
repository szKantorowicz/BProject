use customer_db

CREATE TABLE [dbo].[Status] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    CONSTRAINT [PK_dbo.Status] PRIMARY KEY ([ID])
)