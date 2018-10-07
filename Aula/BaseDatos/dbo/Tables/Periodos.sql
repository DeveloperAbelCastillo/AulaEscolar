CREATE TABLE [dbo].[Periodos] (
    [IdPeriodo]   INT  IDENTITY (1, 1) NOT NULL,
    [FechaInicio] DATE NULL,
    [FechaFin]    DATE NULL,
    CONSTRAINT [PK_Periodos] PRIMARY KEY CLUSTERED ([IdPeriodo] ASC)
);

