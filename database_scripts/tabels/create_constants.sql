use BProject_db

CREATE INDEX [IX_Category_ID] ON [dbo].[CategoryProducts]([Category_ID])
CREATE INDEX [IX_Product_ID] ON [dbo].[CategoryProducts]([Product_ID])
CREATE INDEX [IX_CustomerID] ON [dbo].[Orders]([CustomerID])
CREATE INDEX [IX_PaymentTypeID] ON [dbo].[Orders]([PaymentTypeID])
CREATE INDEX [IX_Status1_ID] ON [dbo].[Orders]([Status1_ID])
CREATE INDEX [IX_OrderID] ON [dbo].[OrderItems]([OrderID])
CREATE INDEX [IX_ProductID] ON [dbo].[OrderItems]([ProductID])
CREATE INDEX [IX_Role_ID] ON [dbo].[Users]([Role_ID])

ALTER TABLE [dbo].[Addresses] ADD CONSTRAINT [FK_dbo.Addresses_dbo.Customers_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([ID])
ALTER TABLE [dbo].[Customers] ADD CONSTRAINT [FK_dbo.Customers_dbo.Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([ID])
ALTER TABLE [dbo].[Orders] ADD CONSTRAINT [FK_dbo.Orders_dbo.Customers_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([ID])
ALTER TABLE [dbo].[Orders] ADD CONSTRAINT [FK_dbo.Orders_dbo.PaymentTypes_PaymentTypeID] FOREIGN KEY ([PaymentTypeID]) REFERENCES [dbo].[PaymentTypes] ([ID])
ALTER TABLE [dbo].[Orders] ADD CONSTRAINT [FK_dbo.Orders_dbo.Status_Status1_ID] FOREIGN KEY ([Status1_ID]) REFERENCES [dbo].[Status] ([ID])
ALTER TABLE [dbo].[OrderItems] ADD CONSTRAINT [FK_dbo.OrderItems_dbo.Orders_OrderID] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([ID])
ALTER TABLE [dbo].[OrderItems] ADD CONSTRAINT [FK_dbo.OrderItems_dbo.Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ID])
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [FK_dbo.Users_dbo.Roles_Role_ID] FOREIGN KEY ([Role_ID]) REFERENCES [dbo].[Roles] ([ID])
ALTER TABLE [dbo].[CategoryProducts] ADD CONSTRAINT [FK_dbo.CategoryProducts_dbo.Categories_Category_ID] FOREIGN KEY ([Category_ID]) REFERENCES [dbo].[Categories] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[CategoryProducts] ADD CONSTRAINT [FK_dbo.CategoryProducts_dbo.Products_Product_ID] FOREIGN KEY ([Product_ID]) REFERENCES [dbo].[Products] ([ID]) ON DELETE CASCADE