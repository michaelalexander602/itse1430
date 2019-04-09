--
-- Updates an existing game.
-- 
-- PARAMS:
--    name - The name of the game. Must be unique and cannot be empty.
--    owned - Specifies if the game is owned or not.
--    completed - Specifies if the game is completed or not.
--    price - Specifies the price of the game. Must be >= 0. Default is 0.
--    description - Specifies the description of the game.
--
-- RETURNS: None.
--
CREATE PROCEDURE [dbo].[UpdateGame]
    @id INT,
	@name NVARCHAR(255),
    @owned BIT,
    @completed BIT,
    @price MONEY,
	@description NVARCHAR(MAX)
AS BEGIN
    SET @name = LTRIM(RTRIM(ISNULL(@name, '')))
            
    -- Validate
    IF LEN(@name) = 0
        THROW 51000, 'Name cannot be empty.', 1
    
    IF @price <= 0
        THROW 51001, 'Price must be >= 0.', 1

    IF NOT EXISTS (SELECT * FROM Games WHERE Id = @id)
        THROW 51002, 'Game not found.', 1

    IF EXISTS (SELECT * FROM Games WHERE Name = @name AND Id <> @id)
        THROW 51003, 'Game already exists.', 1

    -- Update
    SET @description = LTRIM(RTRIM(ISNULL(@description, '')))
    IF LEN(@description) = 0 
        SET @description = NULL

    UPDATE Games
    SET
        Name = @name, 
        Description = @description, 
        Price = @price, 
        Owned = @owned, 
        Completed = @completed
    WHERE Id = @id
END