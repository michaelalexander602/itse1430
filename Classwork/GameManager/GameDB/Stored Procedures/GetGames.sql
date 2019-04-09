--
-- Gets all the games.
--
-- PARAMS: None.
-- 
-- RETURNS: The games.
--
CREATE PROCEDURE [dbo].[GetGames]	
AS BEGIN

    SELECT Name, Description, Price, Owned, Completed
    FROM Games
END