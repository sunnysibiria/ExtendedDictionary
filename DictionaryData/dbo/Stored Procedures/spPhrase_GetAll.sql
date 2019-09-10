CREATE PROCEDURE [dbo].[spPhrase_GetAll]
	
AS
BEGIN

SELECT p.Id, p.Name as PhraseName, p.Translate, p.Translate2, p.Translate3, p.Hint, d.Id as DeckId

FROM dbo.Phrases as p
LEFT OUTER JOIN dbo.Decks as d
on p.DeckId=d.Id

END