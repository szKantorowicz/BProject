use customer_db

CREATE TABLE [dbo].[PaymentTypes] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    CONSTRAINT [PK_dbo.PaymentTypes] PRIMARY KEY ([ID])
)