CREATE TABLE [dbo].[Calificaciones] (
    [IdCalificacion] BIGINT         IDENTITY (1, 1) NOT NULL,
    [IdActividad]    INT            NULL,
    [IdAlumno]       INT            NULL,
    [Calificacion]   DECIMAL (3, 1) NULL,
    CONSTRAINT [PK_Calificaciones] PRIMARY KEY CLUSTERED ([IdCalificacion] ASC)
);

