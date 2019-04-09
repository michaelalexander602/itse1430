--
-- Gets a game.
--
-- PARAMS:
--    id - The ID of the game.
-- 
-- RETURNS: The game, if found.
--
CREATE PROCEDURE [dbo].[GetGame]
	@id INT
AS BEGIN
	
    SELECT Name, Description, Price, Owned, Completed
    FROM Games
    WHERE Id = @id
END
