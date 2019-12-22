use BProject_db


CREATE TABLE [dbo].[Orders] (
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int],
    [TotalAmount] [decimal](18, 2),
    [IsPayed] [bit],
    [PaymentTypeID] [int],
    [Status] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    [Status1_ID] [int],
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY ([ID])
)

