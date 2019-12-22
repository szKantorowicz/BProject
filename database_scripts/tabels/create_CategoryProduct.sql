use BProject_db


CREATE TABLE [dbo].[CategoryProducts] 
(
    [Category_ID] [int] NOT NULL,
    [Product_ID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.CategoryProducts] PRIMARY KEY ([Category_ID], [Product_ID])
)
