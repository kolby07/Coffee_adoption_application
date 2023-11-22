CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [fullName] VARCHAR(50) NULL, 
    [age] INT NULL, 
    [stableIncome] VARCHAR(50) NULL, 
    [hours] FLOAT NULL, 
    [owned] VARCHAR(50) NULL, 
    [yard] VARCHAR(50) NULL
)
