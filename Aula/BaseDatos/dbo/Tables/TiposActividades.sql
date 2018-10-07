CREATE TABLE [dbo].[TiposActividades] (
    [IdTipoActividad] TINYINT       IDENTITY (1, 1) NOT NULL,
    [TipoActividad]   VARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([IdTipoActividad] ASC)
);

