CREATE TABLE [dbo].[Tests] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Period]      DATETIME       NOT NULL,
    [PhraseId]    INT            NOT NULL,
    [Pass]        BIT            NOT NULL,
    [WrongAnswer] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Tests] PRIMARY KEY CLUSTERED ([Id] ASC)
);

