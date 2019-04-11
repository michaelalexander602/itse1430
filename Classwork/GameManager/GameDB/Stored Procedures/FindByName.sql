--
-- Searches for a game given its name.
--
-- PARAMS:
--    name - The name to search for.
--
-- RETURNS: The game, if found.
--
CREATE PROCEDURE [dbo].[FindByName]
	@name NVARCHAR(255)
AS BEGIN
    SET NOCOUNT ON;

    SET @name = LTRIM(RTRIM(ISNULL(@name, '')))

    SELECT Id, Name, Description, Price, Owned, Completed
    FROM Games
    WHERE Name = @name
END
