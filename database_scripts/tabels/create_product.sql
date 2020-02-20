use BProject_db

CREATE TABLE [dbo].[Products] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Category] [int] NOT NULL,
    [Name] [nvarchar](100) NOT NULL,
    [Description] [nvarchar](1000) NOT NULL,
    [Price] [decimal](18, 2) NOT NULL,
    [QuantityInStock] [int] NOT NULL,
    [Availability] [bit] NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY ([ID])
)