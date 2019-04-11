--
-- Gets all the games.
--
-- PARAMS: None.
-- 
-- RETURNS: The games.
--
CREATE PROCEDURE [dbo].[GetGames]	
AS BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, Description, Price, Owned, Completed
    FROM Games
END