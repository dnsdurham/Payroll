CREATE TABLE [dbo].[UnionServiceCharge]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] BIGINT NOT NULL, 
    [ChargeDate] DATE NOT NULL, 
    CONSTRAINT [FK_UnionServiceCharge_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
