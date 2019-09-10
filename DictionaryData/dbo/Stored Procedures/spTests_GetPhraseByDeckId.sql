
create procedure dbo.spTests_GetPhraseByDeckId 
@IdDeck int = null 
as
begin 
select top 1 i.Id from (
	select p.Id, max(t.Period) as Date from dbo.Phrases as p
	left outer join dbo.Tests as t
	on p.Id = t.PhraseId 

	where p.DeckId = @IdDeck

		group by p.Id
		) as i
		left outer join dbo.Tests as t2
		on i.Id = t2.PhraseId and i.Date = t2.Period
		
		order by t2.Pass,i.Date, i.Id

end