create database dbo.customer

create table [User]
(
ID int PRIMARY KEY,
Name nvarchar(100),
Email nvarchar(100),
Password nvarchar(max),
UpdatedDate datetime,
CreatedDate datetime)
)

create table [UserRole]
(
UserID int PRIMARY KEY FOREIGN KEY dbo.[User]
RoleID int PRIMARY KEY FOREIGN KEY dbo.[Role]
)

create table dbo.[Role]
(
ID int NOT NULL PRIMARY KEY 
Name nvarchar(100),
)

create table Customer
(
ID int  NOT NULL PRIMARY KEY Identity
UserID int UNIQUE FOREIGN KEY dbo.User
[Name] nvarchar(100),
Email nvarchar(250),
[Street] nvarchar (250),
PostCode int,
Country nvarchar(250),
)

create table dbo.[Address] 
(
ID int PRIMARY KEY,
CustomerID int FOREIGN KEY dbo.Customer,
Street nvarchar(40),
City nvarchar(40), 
PostCode nvarchar(40),
Level int,
UpdatedDate datetime,
CreatedDate datetime

create table dbo.Product
(
ID int PRIMARY KEY FOREIGN KEY dbo.Product,
CategoryId int FOREIGN KEY dbo.Category,
Name nvarchar(50),
Description nvarchar(max),
Price decimal(10,2),
QuantityInStock int,
Availablity bit,
UpdatedDate datetime,
CreatedDate datetime
)

create table ProductCategory
(
ProductID int PRIMARY KEY FOREIGN KEY dbo.Product
CategoryID int PRIMARY KEY FOREIGN KEY dbo.Category
)

create table Category
(
ID int PRIMARY KEY,
Name nvarchar(100),
[Description] nvarchar(100)
)

create table dbo.[Order]
(
ID int  NOT NULL PRIMARY KEY 
CustomerID int FOREIGN KEY dbo.Customer,
TotalAmount int,
PaymentType int,
IsPayed bit, 
PaymentTypeID int FOREIGN KEY dbo.PaymentType
[Status] int,
StatusID int FOREIGN KEY dbo.Status,
UpdatedDate datetime,
CreatedDate datetime
)

create table dbo.OrderItem
(
ID int  NOT NULL PRIMARY KEY,
OrderID int FOREIGN KEY dbo.Order,
ProductID int FOREIGN KEY dbo.Product,
UnitPrice decimal(10,2),
Price int,
TotalPrice decimal(10,2),
Quantity int,
UpdatedDate datetime,
CreatedDate datetime
)

create table dbo.[Status]
(
ID int  NOT NULL PRIMARY KEY,
[Name] nvarchar(100)
)

create table dbo.PaymentType
(
ID int  NOT NULL PRIMARY KEY,
[Name] nvarchar(100)
)

alter table dbo.[UserRole] alter column UserID int NOT NULL 
alter table dbo.[UserRole] alter column RoleID int NOT NULL
alter table dbo.[UserRole] add constraint PK_User_Role primary key (UserID,RoleID) 
alter table dbo.[UserRole] add constraint Fk_User foreign key (UserID) references dbo.[User] (ID) on delete cascade on update cascade
alter table dbo.[UserRole] add constraint Fk_Role foreign key (RoleID) references dbo.[Role] (ID) on delete cascade on update cascade

alter table dbo.Customer add constraint UQ_Customer_UserID UNIQUE (UserID)
alter table dbo.[Customer] add constraint Fk_Customer_User foreign key (UserID) references dbo.[User] (ID) on delete cascade on update cascade

alter table dbo.[Address] add constraint Fk_Address_Customer foreign key (CustomerID) references dbo.[Customer] (ID) on delete cascade on update cascade

alter table dbo.[Order] add constraint Fk_Order_Customer foreign key (CustomerID) references dbo.[Customer] (ID) on delete cascade on update cascade

alter table dbo.[ProductCategory] add constraint Fk_ProductCategory_Product foreign key ([ProductID]) references dbo.[Product] (ID) on delete cascade on update cascade

alter table dbo.[ProductCategory] add constraint Fk_ProductCategory_Category foreign key ([CategoryID]) references dbo.[Category] (ID) on delete cascade on update cascade

alter table dbo.[Order] add constraint Fk_Order_Status foreign key ([StatusID]) references dbo.[Status] (ID) on delete cascade on update cascade

alter table dbo.[Order] add constraint Fk_Order_PaymentType foreign key ([PaymentTypeID]) references dbo.[PaymentType] (ID) on delete cascade on update cascade

alter table dbo.OrderItem add constraint FK_OrderItem_Order foreign key (OrderID) references dbo.[Order] (ID) on delete cascade on update cascade

alter table dbo.OrderItem add constraint FK_OrderItem_Product foreign key (ProductID) references dbo.[Product] (ID) on delete cascade on update cascade
