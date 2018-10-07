CREATE TABLE [dbo].[FileStream] (
    [Id]          INT              IDENTITY (1, 1) NOT NULL,
    [StreamId]    UNIQUEIDENTIFIER NOT NULL,
    [Descripcion] NVARCHAR (64)    NOT NULL,
    [Extencion]   NVARCHAR (64)    NOT NULL,
    [FileData]    VARBINARY (MAX)  NULL,
    CONSTRAINT [PK_FileStream] PRIMARY KEY CLUSTERED ([Id] ASC)
);

