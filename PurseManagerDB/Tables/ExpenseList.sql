CREATE TABLE [dbo].[ExpenseList]
(
	[Id]              INT            IDENTITY (1, 1) NOT NULL,
    [NameOfExpense] NVARCHAR (50)  NULL
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
