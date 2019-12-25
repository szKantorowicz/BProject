use BProject_db

CREATE TABLE [dbo].[Addresses] 
(
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int] NOT NULL,
    [Street] [nvarchar](100) NOT NULL,
    [City] [nvarchar](100) NOT NULL,
    [Postcode] [nvarchar](6) NOT NULL,
    [Country] [nvarchar](max),
    [Level] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Addresses] PRIMARY KEY ([ID])
)
