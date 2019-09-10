CREATE PROCEDURE [dbo].[spDecks_GetAll]
	
AS
	BEGIN
		SELECT d.Id, d.Name as DeckName
		FROM dbo.Decks as d
		order by Name
	END