CREATE TABLE [dbo].[Bitacora] (
    [IdBitacora]       INT           IDENTITY (1, 1) NOT NULL,
    [IdAula]           INT           NULL,
    [Fecha]            DATE          NULL,
    [IdNivelSeguridad] TINYINT       NULL,
    [Anotacion]        VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED ([IdBitacora] ASC)
);

