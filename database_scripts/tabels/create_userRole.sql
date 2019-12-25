use BProject_db

CREATE TABLE [dbo].[UserRole] 
(
    [UserID] [int] NOT NULL,
    [RoleID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.UserRole] PRIMARY KEY ([UserID], [RoleID])
)