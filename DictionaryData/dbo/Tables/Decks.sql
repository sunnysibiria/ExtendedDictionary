CREATE TABLE [dbo].[Decks] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [name] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Decks] PRIMARY KEY CLUSTERED ([Id] ASC)
);

