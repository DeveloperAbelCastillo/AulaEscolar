CREATE TABLE [dbo].[Aulas] (
    [IdAula]    INT         IDENTITY (1, 1) NOT NULL,
    [Grado]     INT         NOT NULL,
    [Grupo]     VARCHAR (1) NOT NULL,
    [IdUsuario] INT         NOT NULL,
    CONSTRAINT [PK_Aulas] PRIMARY KEY CLUSTERED ([IdAula] ASC)
);

