use customer_db

CREATE TABLE [dbo].[Users] 
(
    [ID] [int] NOT NULL IDENTITY,
    [Name] [nvarchar](max),
    [Email] [nvarchar](max),
    [Password] [nvarchar](max),
    [UpdatedDate] [datetime],
    [CreatedDate] [datetime],
    [Role_ID] [int],
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY ([ID])
)
CREATE INDEX [IX_Role_ID] ON [dbo].[Users]([Role_ID])