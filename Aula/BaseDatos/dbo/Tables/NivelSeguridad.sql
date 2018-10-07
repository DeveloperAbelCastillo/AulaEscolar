CREATE TABLE [dbo].[NivelSeguridad] (
    [IdNivelSeguridad] TINYINT       IDENTITY (1, 1) NOT NULL,
    [Nivel]            VARCHAR (50)  NULL,
    [Clave]            VARCHAR (250) NULL,
    CONSTRAINT [PK_NivelSeguridad] PRIMARY KEY CLUSTERED ([IdNivelSeguridad] ASC)
);



