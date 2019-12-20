use customer_db

CREATE TABLE [dbo].[OrderItems] (
    [ID] [int] NOT NULL IDENTITY,
    [OrderID] [int],
    [ProductID] [int],
    [UnitPrice] [decimal](18, 2),
    [TotalPrice] [decimal](18, 2),
    [Quantity] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.OrderItems] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_OrderID] ON [dbo].[OrderItems]([OrderID])
CREATE INDEX [IX_ProductID] ON [dbo].[OrderItems]([ProductID])