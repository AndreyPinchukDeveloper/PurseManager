CREATE TABLE [dbo].[HistoryOfOperations]
(
	 [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [NameOfOperation] NVARCHAR (50)  NULL,
    [ValueToChange]   MONEY          NOT NULL,
    [AmountOfMoney]   MONEY          NOT NULL,
    [Notes]           NVARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
