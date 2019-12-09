use customer_db

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