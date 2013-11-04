CREATE TABLE [dbo].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] VARCHAR(50) NULL, 
    [Price] MONEY NULL, 
    [Quantity] INT NULL, 
    [PersonId] INT NULL, 
    CONSTRAINT [FK_Item_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
