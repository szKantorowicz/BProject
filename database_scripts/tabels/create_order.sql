use customer_db


CREATE TABLE [dbo].[Orders] (
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int],
    [TotalAmount] [decimal](18, 2),
    [IsPayed] [bit],
    [PaymentTypeID] [int],
    [Status] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    [Status1_ID] [int],
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_CustomerID] ON [dbo].[Orders]([CustomerID])
CREATE INDEX [IX_PaymentTypeID] ON [dbo].[Orders]([PaymentTypeID])
CREATE INDEX [IX_Status1_ID] ON [dbo].[Orders]([Status1_ID])
