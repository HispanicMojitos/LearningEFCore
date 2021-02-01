CREATE TABLE [dbo].[Students] (
    [StudentID]   INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (MAX) NOT NULL,
    [LastName]    NVARCHAR (MAX) NOT NULL,
    [BirthDate]   DATE           NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

