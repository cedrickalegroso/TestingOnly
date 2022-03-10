CREATE TABLE [dbo].[UnitDetail]
(
	[Id] INT NOT NULL PRIMARY, 
    [UnitName] VARCHAR(50) NOT NULL, 
    [Furnishing] VARCHAR(50) NOT NULL, 
    [Bedroom] INT NOT NULL, 
    [Bath] INT NOT NULL, 
    [FloorArea] VARCHAR(50) NOT NULL, 
    [Net Price] DECIMAL NOT NULL, 
    [UnitTypeID] INT NOT NULL IDENTITY, 
    CONSTRAINT [FK_UnitDetail_UnitType] FOREIGN KEY ([UnitTypeID]) REFERENCES [UnitType]([Id]) 
)
