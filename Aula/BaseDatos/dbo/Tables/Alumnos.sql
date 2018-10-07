CREATE TABLE [dbo].[Alumnos] (
    [IdAlumno] INT          IDENTITY (1, 1) NOT NULL,
    [Nombre]   VARCHAR (50) NOT NULL,
    [Paterno]  VARCHAR (50) NOT NULL,
    [Materno]  VARCHAR (50) NOT NULL,
    [IdAula]   INT          NOT NULL,
    CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED ([IdAlumno] ASC)
);

