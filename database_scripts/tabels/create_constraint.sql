use BProject_db

CREATE INDEX [IX_CustomerID] ON [dbo].[Orders]([CustomerID])
CREATE INDEX [IX_PaymentTypeID] ON [dbo].[Orders]([PaymentTypeID])
CREATE INDEX [IX_StatusID] ON [dbo].[Orders]([StatusID])
CREATE INDEX [IX_OrderID] ON [dbo].[OrderItems]([OrderID])
CREATE INDEX [IX_ProductID] ON [dbo].[OrderItems]([ProductID])
CREATE INDEX [IX_CustomerID] ON [dbo].[Addresses]([CustomerID])
CREATE INDEX [IX_UserID] ON [dbo].[UserRole]([UserID])
CREATE INDEX [IX_RoleID] ON [dbo].[UserRole]([RoleID])
CREATE INDEX [IX_ProductID] ON [dbo].[ProductCategory]([ProductID])
CREATE INDEX [IX_CategoryID] ON [dbo].[ProductCategory]([CategoryID])
CREATE INDEX [IX_CustomerID] ON [dbo].[Users]([CustomerID])
CREATE INDEX [IX_CustomerID] ON [dbo].[Addresses]([CustomerID])
CREATE INDEX [IX_UserID] ON [dbo].[Customers]([UserID])

ALTER TABLE [dbo].[Addresses] ADD CONSTRAINT [FK_dbo.Addresses_dbo.Customers_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[Customers] ADD CONSTRAINT [FK_dbo.Customers_dbo.Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([ID])
ALTER TABLE [dbo].[Orders] ADD CONSTRAINT [FK_dbo.Orders_dbo.PaymentTypes_PaymentTypeID] FOREIGN KEY ([PaymentTypeID]) REFERENCES [dbo].[PaymentTypes] ([ID])
ALTER TABLE [dbo].[Orders] ADD CONSTRAINT [FK_dbo.Orders_dbo.Status_StatusID] FOREIGN KEY ([StatusID]) REFERENCES [dbo].[Status] ([ID])
ALTER TABLE [dbo].[Orders] ADD CONSTRAINT [FK_dbo.Orders_dbo.Customers_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[OrderItems] ADD CONSTRAINT [FK_dbo.OrderItems_dbo.Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[OrderItems] ADD CONSTRAINT [FK_dbo.OrderItems_dbo.Orders_OrderID] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[Users] ADD CONSTRAINT [FK_dbo.Users_dbo.Customers_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[ProductCategory] ADD CONSTRAINT [FK_dbo.ProductCategory_dbo.Products_ProductID] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[ProductCategory] ADD CONSTRAINT [FK_dbo.ProductCategory_dbo.Categories_CategoryID] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[Categories] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[UserRole] ADD CONSTRAINT [FK_dbo.UserRole_dbo.Users_UserID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([ID]) ON DELETE CASCADE
ALTER TABLE [dbo].[UserRole] ADD CONSTRAINT [FK_dbo.UserRole_dbo.Roles_RoleID] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Roles] ([ID]) ON DELETE CASCADE
