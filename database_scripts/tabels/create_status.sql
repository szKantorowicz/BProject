use customer_db

create table dbo.[Status]
(
ID int  NOT NULL PRIMARY KEY Identity(1,1),
[Name] nvarchar(100)
)