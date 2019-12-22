use BProject_db

CREATE TABLE [dbo].[Addresses] 
(
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int],
    [Street] [nvarchar](100) NOT NULL,
    [City] [nvarchar](100) NOT NULL,
    [Postcode] [nvarchar](6) NOT NULL,
    [Country] [nvarchar](100) NOT NULL,
    [Level] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Addresses] PRIMARY KEY ([ID])
)
