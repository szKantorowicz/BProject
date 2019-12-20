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

CREATE INDEX [IX_CustomerID] ON [dbo].[Addresses]([CustomerID])

CREATE TABLE [dbo].[Customers]
(
    [ID] [int] NOT NULL IDENTITY,
    [UserID] [int],
    [FirstName] [nvarchar](max),
    [LastName] [nvarchar](max),
    [UserName] [nvarchar](max),
    [Email] [nvarchar](max),
    [Phone] [nvarchar](max),
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY ([ID])
)

CREATE INDEX [IX_UserID] ON [dbo].[Customers]([UserID])

CREATE TABLE [dbo].[Orders] 
(
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int],
    [TotalAmount] [decimal](18, 2),
    [IsPayed] [bit],
    [PaymentTypeID] [int],
    [Status] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    [Status1_ID] [int],
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY ([ID])
)

CREATE INDEX [IX_CustomerID] ON [dbo].[Orders]([CustomerID])
CREATE INDEX [IX_PaymentTypeID] ON [dbo].[Orders]([PaymentTypeID])
CREATE INDEX [IX_Status1_ID] ON [dbo].[Orders]([Status1_ID])

CREATE TABLE [dbo].[OrderItems] 
(
    [ID] [int] NOT NULL IDENTITY,
    [OrderID] [int],
    [ProductID] [int],
    [UnitPrice] [decimal](18, 2),
    [TotalPrice] [decimal](18, 2),
    [Quantity] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.OrderItems] PRIMARY KEY ([ID])
)

CREATE INDEX [IX_OrderID] ON [dbo].[OrderItems]([OrderID])
CREATE INDEX [IX_ProductID] ON [dbo].[OrderItems]([ProductID])

CREATE TABLE [dbo].[Products] (
    [ID] [int] NOT NULL IDENTITY,
    [Category] [int],
    [Name] [nvarchar](max),
    [Description] [nvarchar](max),
    [Price] [decimal](18, 2),
    [Quantityinstock] [int],
    [Avilability] [bit],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY ([ID])
)

CREATE TABLE [dbo].[Categories] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Description] [nvarchar](max),
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY ([ID])
)

CREATE TABLE [dbo].[PaymentTypes] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    CONSTRAINT [PK_dbo.PaymentTypes] PRIMARY KEY ([ID])
)

CREATE TABLE [dbo].[Status] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    CONSTRAINT [PK_dbo.Status] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[Users] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Email] [nvarchar](max),
    [Password] [nvarchar](max),
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    [Role_ID] [int],
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY ([ID])
)

CREATE INDEX [IX_Role_ID] ON [dbo].[Users]([Role_ID])

CREATE TABLE [dbo].[Roles] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    CONSTRAINT [PK_dbo.Roles] PRIMARY KEY ([ID])
)

CREATE TABLE [dbo].[CategoryProducts] 
(
    [Category_ID] [int] NOT NULL,
    [Product_ID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.CategoryProducts] PRIMARY KEY ([Category_ID], [Product_ID])
)

CREATE INDEX [IX_Category_ID] ON [dbo].[CategoryProducts]([Category_ID])
CREATE INDEX [IX_Product_ID] ON [dbo].[CategoryProducts]([Product_ID])FK_OrderItem_Product foreign key (ProductID) references dbo.[Product] (ID) on delete cascade on update cascade

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
