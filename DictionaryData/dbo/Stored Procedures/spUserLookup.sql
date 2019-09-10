CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128) 
AS
begin
	set nocount on;	
	SELECT [Id], [AuthUserId], [FirstName], [LastName], [EmailAddress], [CreatedData] FROM [dbo].[User] WHERE AuthUserId = @Id
end