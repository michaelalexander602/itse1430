--
-- Adds a game to the system.
--
-- PARAMS:
--    name - The name of the game. Must be unique and cannot be empty.
--    owned - Specifies if the game is owned or not.
--    completed - Specifies if the game is completed or not.
--    price - Specifies the price of the game. Must be >= 0. Default is 0.
--    description - Specifies the description of the game.
--
-- RETURNS: The ID of the game.
--
CREATE PROCEDURE [dbo].[AddGame]
	@name NVARCHAR(255),
    @owned BIT,
    @completed BIT,
    @price MONEY = 0,
	@description NVARCHAR(MAX) = NULL
AS BEGIN
    SET @name = lTRIM(RTRIM(ISNULL(@name, '')))

    -- Validate
	IF LEN(@name) = 0
        THROW 51000, 'Name cannot be empty.', 1
    
    IF @price <= 0
        THROW 51001, 'Price must be >= 0.', 1

    IF EXISTS (SELECT * FROM Games WHERE Name = @name)
        THROW 51002, 'Game already exists.', 1

    -- Add
    SET @description = LTRIM(RTRIM(ISNULL(@description, '')))
    IF LEN(@description) = 0 
        SET @description = NULL

    INSERT INTO Games (Name, Description, Price, Owned, Completed) 
        VALUES (@name, @description, @price, @owned, @completed)

    RETURN SCOPE_IDENTITY()
END