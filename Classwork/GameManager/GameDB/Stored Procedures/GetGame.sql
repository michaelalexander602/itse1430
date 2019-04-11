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
	SET NOCOUNT ON;

    SELECT Id, Name, Description, Price, Owned, Completed
    FROM Games
    WHERE Id = @id
END
