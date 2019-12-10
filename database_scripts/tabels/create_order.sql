use customer_db


create table dbo.[Order]
(
ID int  NOT NULL PRIMARY KEY 
CustomerID int FOREIGN KEY dbo.Customer,
TotalAmount int,
PaymentType int,
IsPayed bit, PaymentTypeID int FOREIGN KEY dbo.PaymentType
[Status] int,
StatusID int FOREIGN KEY dbo.Status,
UpdatedDate datetime,
CreatedDate datetime
)