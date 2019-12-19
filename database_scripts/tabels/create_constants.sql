use customer_db

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
