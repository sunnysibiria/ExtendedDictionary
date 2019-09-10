
CREATE PROCEDURE [dbo].[spGetNextPharse]
@IdDeck int = null 
as
begin 
select top 1 i.Id, e.Name, e.Translate, e.Hint, e.DeckId   
	from (
			select p.Id, max(t.Period) as Date from dbo.Phrases as p
			left outer join dbo.Tests as t
			on p.Id = t.PhraseId			
			where p.DeckId = @IdDeck

			group by p.Id
		) as i
	left outer join dbo.Tests as t2
	on i.Id = t2.PhraseId and i.Date = t2.Period
	inner join dbo.Phrases as e 
	on i.Id = e.Id
	order by t2.Pass,i.Date, i.Id

end