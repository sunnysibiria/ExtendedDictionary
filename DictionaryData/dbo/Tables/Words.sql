CREATE TABLE [dbo].[Words] (
    [Id]        INT        IDENTITY (1, 1) NOT NULL,
    [Phrase]    CHAR (150) NOT NULL,
    [Translate] CHAR (150) NOT NULL,
    [Hint]      CHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

