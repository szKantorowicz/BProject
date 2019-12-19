use customer_db

create table [User]
(
ID int PRIMARY KEY,
Name nvarchar(100),
Email nvarchar(100),
Password nvarchar(max),
UpdatedDate datetime,
CreatedDate datetime)
)
