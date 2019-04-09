CREATE TABLE [dbo].[Games]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(255) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Price] MONEY NOT NULL DEFAULT 0, 
    [Owned] BIT NOT NULL DEFAULT 0, 
    [Completed] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [CK_Games_Name_NotEmpty] CHECK (Len(Name) > 0), 
    CONSTRAINT [CK_Games_Price_Positive] CHECK (Price >= 0), 
    CONSTRAINT [AK_Games_Name] UNIQUE (Name)
)
