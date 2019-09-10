CREATE PROCEDURE [dbo].[spPhrase_Insert]
	@Id int out,
	@PhraseName nvarchar(max),
	@Translate nvarchar(max),
	@Translate2 nvarchar(max),
	@Translate3 nvarchar(max),
	@Hint nvarchar(max),
	@DeckId int


AS
BEGIN
set nocount on;
if 
	EXISTS (Select * from dbo.Phrases Where Id = @id)
		BEGIN
			Update dbo.Phrases
			SET Name = @PhraseName, Translate = @Translate, Translate2 = @Translate2, Translate3 = @Translate3, Hint = @Hint, DeckId = DeckId
			WHERE Id = @ID
			Select @Id as Id
		END
	ELSE
		BEGIN
			INSERT INTO dbo.Phrases(Name,Translate,Translate2,Translate3,Hint,DeckId) Values(@PhraseName, @Translate, @Translate2, @Translate3, @Hint, @DeckId)
			select SCOPE_IDENTITY() as Id
		END
END