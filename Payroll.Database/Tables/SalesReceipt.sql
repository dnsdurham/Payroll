CREATE TABLE [dbo].[SalesReceipt]
(
    [Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] BIGINT NOT NULL, 
    [SaleDate] DATE NOT NULL, 
    CONSTRAINT [FK_SalesReceipt_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
