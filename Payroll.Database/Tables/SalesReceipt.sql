CREATE TABLE [dbo].[SalesReceipt]
(
    [Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] NCHAR(10) NOT NULL, 
    [SaleDate] DATE NOT NULL
)
