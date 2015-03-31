CREATE TABLE [dbo].[Employee]
(
    [Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] VARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [DateOfHire] DATE NOT NULL
)
