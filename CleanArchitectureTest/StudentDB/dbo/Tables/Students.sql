CREATE TABLE [dbo].[Students] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (MAX) NOT NULL,
    [LastName]    NVARCHAR (MAX) NOT NULL,
    [BirthDate]   DATETIME2           NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([Id] ASC)
);

