CREATE TABLE [dbo].[Paycheck]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] BIGINT NOT NULL, 
    [PayDate] DATE NOT NULL, 
    CONSTRAINT [FK_Paycheck_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
