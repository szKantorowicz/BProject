use customer_db


create table ProductCategory
(ProductID int PRIMARY KEY FOREIGN KEY dbo.Product
CategoryID int PRIMARY KEY FOREIGN KEY dbo.Category)