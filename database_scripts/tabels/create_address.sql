use customer_db

CREATE TABLE [dbo].[Addresses] 
(
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int],
    [Street] [nvarchar](100),
    [City] [nvarchar](100),
    [Postcode] [nvarchar](6),
    [Country] [nvarchar](100),
    [Level] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.Addresses] PRIMARY KEY ([ID])
)
