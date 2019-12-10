use customer_db

create table dbo.Address 
(
ID int PRIMARY KEY,
CustomerID int FOREIGN KEY dbo.Customer,
Street nvarchar(40),
City nvarchar(40), PostCodenvarchar(10),
Country nvarchar(40),
Level int,
UpdatedDate datetime,
CreatedDate datetime
)