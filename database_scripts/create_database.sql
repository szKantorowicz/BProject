use BProject_db

CREATE TABLE [dbo].[Addresses] (
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

CREATE TABLE [dbo].[Customers] (
    [ID] [int] NOT NULL IDENTITY,
    [UserID] [int] NOT NULL,
    [FirstName] [nvarchar](100),
    [LastName] [nvarchar](100),
    [UserName] [nvarchar](100) NOT NULL,
    [Email] [nvarchar](100) NOT NULL,
    [Phone] [nvarchar](10),
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY ([ID])
)

CREATE TABLE [dbo].[Orders] (
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int] NOT NULL,
    [TotalAmount] [decimal](18, 2),
    [IsPayed] [bit],
    [PaymentTypeID] [int],
    [StatusID] [int],
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY ([ID])
)

CREATE TABLE [dbo].[OrderItems] (
    [ID] [int] NOT NULL IDENTITY,
    [OrderID] [int] NOT NULL,
    [ProductID] [int] NOT NULL,
    [UnitPrice] [decimal](18, 2) NOT NULL,
    [TotalPrice] [decimal](18, 2) NOT NULL,
    [Quantity] [int] NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.OrderItems] PRIMARY KEY ([ID])
)

CREATE TABLE [dbo].[Products] (
    [ID] [int] NOT NULL IDENTITY,
    [Category] [int] NOT NULL,
    [Name] [nvarchar](100) NOT NULL,
    [Description] [nvarchar](1000) NOT NULL,
    [Price] [decimal](18, 2) NOT NULL,
    [QuantityInStock] [int] NOT NULL,
    [Availability] [bit] NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[Categories] (
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL,
    [Description] [nvarchar](1000),
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[PaymentTypes] (
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL,
    CONSTRAINT [PK_dbo.PaymentTypes] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[Status] (
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL,
    CONSTRAINT [PK_dbo.Status] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[Users] (
    [ID] [int] NOT NULL IDENTITY,
    [CustomerID] [int] NOT NULL,
    [Name] [nvarchar](100) NOT NULL,
    [Email] [nvarchar](100) NOT NULL,
    [Password] [nvarchar](200) NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY ([ID])
)

CREATE TABLE [dbo].[Roles] (
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    CONSTRAINT [PK_dbo.Roles] PRIMARY KEY ([ID])
)
CREATE TABLE [dbo].[ProductCategory] (
    [ProductID] [int] NOT NULL,
    [CategoryID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.ProductCategory] PRIMARY KEY ([ProductID], [CategoryID])
)

CREATE TABLE [dbo].[UserRole] (
    [UserID] [int] NOT NULL,
    [RoleID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.UserRole] PRIMARY KEY ([UserID], [RoleID])
)
CREATE INDEX [CustomerID] ON [dbo].[Orders]([CustomerID])
CREATE INDEX [PaymentTypeID] ON [dbo].[Orders]([PaymentTypeID])
CREATE INDEX [StatusID] ON [dbo].[Orders]([StatusID])
CREATE INDEX [OrderID] ON [dbo].[OrderItems]([OrderID])
CREATE INDEX [ProductID] ON [dbo].[OrderItems]([ProductID])
CREATE INDEX [CustomerID] ON [dbo].[Addresses]([CustomerID])
CREATE INDEX [UserID] ON [dbo].[UserRole]([UserID])
CREATE INDEX [RoleID] ON [dbo].[UserRole]([RoleID])
CREATE INDEX [ProductID] ON [dbo].[ProductCategory]([ProductID])
CREATE INDEX [CategoryID] ON [dbo].[ProductCategory]([CategoryID])
CREATE INDEX [CustomerID] ON [dbo].[Users]([CustomerID])
CREATE INDEX [CustomerID] ON [dbo].[Addresses]([CustomerID])
CREATE INDEX [UserID] ON [dbo].[Customers]([UserID])

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
