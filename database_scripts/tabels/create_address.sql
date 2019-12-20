use customer_db

CREATE TABLE [dbo].[Addresses] 
(
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int],
    [Street] [nvarchar](max),
    [City] [nvarchar](max),
    [Postcode] [nvarchar](max),
    [Country] [nvarchar](max),
    [Level] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.Addresses] PRIMARY KEY ([ID])

)
