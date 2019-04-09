--
-- Deletes a game.
--
-- PARAMS:
--    id - The ID of the game to remove.
--
-- RETURNS: None.
--
CREATE PROCEDURE [dbo].[DeleteGame]
	@id INT
AS BEGIN
	
    DELETE FROM Games WHERE Id = @id
END
