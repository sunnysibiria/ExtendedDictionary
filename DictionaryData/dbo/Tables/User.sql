CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [AuthUserId] NCHAR(128) NOT NULL, 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NOT NULL, 
    [EmailAddress] NCHAR(10) NOT NULL, 
    [CreatedData] DATETIME2 NOT NULL DEFAULT getutcdate()
)
