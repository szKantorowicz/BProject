use customer_db

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