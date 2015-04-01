CREATE TABLE [dbo].[TimeCard]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] BIGINT NOT NULL, 
    [CardDate] DATE NOT NULL, 
    CONSTRAINT [FK_TimeCard_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([Id])
)
