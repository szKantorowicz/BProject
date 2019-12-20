use customer_db


CREATE TABLE [dbo].[CategoryProducts] 
(
    [Category_ID] [int] NOT NULL,
    [Product_ID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.CategoryProducts] PRIMARY KEY ([Category_ID], [Product_ID])
)
CREATE INDEX [IX_Category_ID] ON [dbo].[CategoryProducts]([Category_ID])
CREATE INDEX [IX_Product_ID] ON [dbo].[CategoryProducts]([Product_ID])