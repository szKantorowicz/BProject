use BProject_db

CREATE TABLE [dbo].[PaymentTypes] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL,
    CONSTRAINT [PK_dbo.PaymentTypes] PRIMARY KEY ([ID])
)