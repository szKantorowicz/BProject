use BProject_db

CREATE TABLE [dbo].[Users] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](100) NOT NULL ,
    [Email] [nvarchar](100) NOT NULL,
    [Password] [nvarchar](100) NOT NULL,
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime] NOT NULL,
    [Role_ID] [int] NOT NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY ([ID])
)
