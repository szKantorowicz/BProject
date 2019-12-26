use BProject_db

CREATE TABLE [dbo].[OrderItems] (
    [ID] [int] NOT NULL IDENTITY,
    [OrderID] [int] NOT NULL,
    [ProductID] [int] NOT NULL,
    [UnitPrice] [decimal](18, 2) NOT NULL,
    [TotalPrice] [decimal](18, 2) NOT NULL,
    [Quantity] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.OrderItems] PRIMARY KEY ([ID])
)
