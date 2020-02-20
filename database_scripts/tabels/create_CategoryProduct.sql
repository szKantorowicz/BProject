use BProject_db


CREATE TABLE [dbo].[ProductCategory] (
    [ProductID] [int] NOT NULL,
    [CategoryID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.ProductCategory] PRIMARY KEY ([ProductID], [CategoryID])
)