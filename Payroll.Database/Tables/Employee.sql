CREATE TABLE [dbo].[Employee]
(
    [Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] VARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [HireDate] DATE NOT NULL, 
    [UnionId] BIGINT NULL, 
    CONSTRAINT [FK_Employee_Union] FOREIGN KEY ([UnionId]) REFERENCES [Union]([Id])
)
