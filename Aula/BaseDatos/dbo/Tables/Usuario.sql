CREATE TABLE [dbo].[Usuario] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]    VARCHAR (50)  NOT NULL,
    [Paterno]   VARCHAR (50)  NOT NULL,
    [Materno]   VARCHAR (50)  NOT NULL,
    [Escuela]   VARCHAR (50)  NOT NULL,
    [Direccion] VARCHAR (250) NULL,
    [Telefono]  VARCHAR (50)  NULL,
    [Logo]      INT           NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC)
);

