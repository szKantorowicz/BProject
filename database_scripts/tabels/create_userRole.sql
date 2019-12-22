use BProject_db

create table [UserRole]
(
UserID int PRIMARY KEY FOREIGN KEY dbo.[User]
RoleID int PRIMARY KEY FOREIGN KEY dbo.[Role]
)
