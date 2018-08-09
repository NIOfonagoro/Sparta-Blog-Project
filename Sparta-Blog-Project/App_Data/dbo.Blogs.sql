CREATE TABLE [dbo].[Blogs] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Title]   NVARCHAR (50)  NOT NULL,
    [Author]  NVARCHAR (50)  NOT NULL,
    [Content] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_dbo.Blogs] PRIMARY KEY CLUSTERED ([Id] ASC)
);

