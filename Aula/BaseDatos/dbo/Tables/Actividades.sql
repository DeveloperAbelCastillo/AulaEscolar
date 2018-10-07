CREATE TABLE [dbo].[Actividades] (
    [IdTarea]         INT           IDENTITY (1, 1) NOT NULL,
    [Tema]            VARCHAR (150) NULL,
    [Descripcion]     VARCHAR (MAX) NULL,
    [FechaCreacion]   DATE          NULL,
    [FechaEntrega]    DATETIME      NULL,
    [IdMateria]       NCHAR (10)    NULL,
    [IdFileStream]    INT           NULL,
    [TiempoRevision]  DATETIME      NULL,
    [IdTipoActividad] TINYINT       NULL,
    PRIMARY KEY CLUSTERED ([IdTarea] ASC)
);

