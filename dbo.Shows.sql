CREATE TABLE [dbo].[Shows] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Year]        INT            NOT NULL,
    CONSTRAINT [PK_Shows] PRIMARY KEY CLUSTERED ([Id] ASC)
);

