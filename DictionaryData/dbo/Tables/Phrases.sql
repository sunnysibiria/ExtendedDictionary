CREATE TABLE [dbo].[Phrases] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (MAX) NULL,
    [Translate] NVARCHAR (MAX) NULL,
	[Translate2] NVARCHAR (MAX) NULL,
	[Translate3] NVARCHAR (MAX) NULL,
    [Hint]      NVARCHAR (MAX) NULL,
    [DeckId]    INT            NULL,
    CONSTRAINT [PK_dbo.Phrases] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Phrases_dbo.Decks_DeckId] FOREIGN KEY ([DeckId]) REFERENCES [dbo].[Decks] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_DeckId]
    ON [dbo].[Phrases]([DeckId] ASC);

