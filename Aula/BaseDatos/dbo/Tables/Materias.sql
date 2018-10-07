CREATE TABLE [dbo].[Materias] (
    [IdMateria] INT          IDENTITY (1, 1) NOT NULL,
    [Materia]   VARCHAR (50) NOT NULL,
    [IdAula]    INT          NOT NULL,
    [ColorRGB]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED ([IdMateria] ASC)
);

