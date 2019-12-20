use customer_db

CREATE TABLE [dbo].[Products] (
    [ID] [int] NOT NULL IDENTITY,
    [Category] [int],
    [Name] [nvarchar](max),
    [Description] [nvarchar](max),
    [Price] [decimal](18, 2),
    [Quantityinstock] [int],
    [Avilability] [bit],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY ([ID])
)