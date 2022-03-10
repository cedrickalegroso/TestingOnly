CREATE TABLE [dbo].[UnitDetail] (
    [Id]         INT          NOT NULL IDENTITY,
    [UnitName]   VARCHAR (50) NOT NULL,
    [Furnishing] VARCHAR (50) NOT NULL,
    [Bedroom]    INT          NOT NULL,
    [Bath]       INT          NOT NULL,
    [FloorArea]  VARCHAR (50) NOT NULL,
    [Net Price]  DECIMAL (18) NOT NULL,
    [UnitTypeID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UnitDetail_UnitType] FOREIGN KEY ([UnitTypeID]) REFERENCES [dbo].[UnitType] ([Id])
);

