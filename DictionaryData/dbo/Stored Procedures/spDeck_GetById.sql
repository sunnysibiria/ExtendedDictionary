CREATE PROCEDURE [dbo].[spDeck_GetById]
	@Id int
AS
	BEGIN
		SELECT d.Id, d.Name as DeckName
		FROM dbo.Decks as d
		WHERE d.Id = @Id
	END