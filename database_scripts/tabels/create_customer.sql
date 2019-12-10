use customer_db

create table Customer
(
ID int  NOT NULL PRIMARY KEY Identity(1,1),
UserID int UNIQUE FOREIGN KEY dbo.User
[Name] nvarchar(100),
Email nvarchar(250),
[Street] nvarchar (250),
PostCode int,
Country nvarchar(250),
)