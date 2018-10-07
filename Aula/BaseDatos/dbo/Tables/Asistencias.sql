CREATE TABLE [dbo].[Asistencias] (
    [IdAsistencia]    INT      IDENTITY (1, 1) NOT NULL,
    [IdAlumno]        INT      NULL,
    [IdAula]          INT      NULL,
    [FechaAsistencia] DATETIME NULL,
    CONSTRAINT [PK_Asistencias] PRIMARY KEY CLUSTERED ([IdAsistencia] ASC)
);

