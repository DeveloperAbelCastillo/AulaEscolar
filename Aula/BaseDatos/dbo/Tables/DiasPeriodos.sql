CREATE TABLE [dbo].[DiasPeriodos] (
    [IdDia]     INT  IDENTITY (1, 1) NOT NULL,
    [IdPeriodo] INT  NULL,
    [Fecha]     DATE NULL,
    [Laboral]   BIT  NOT NULL,
    CONSTRAINT [PK_DiasPeriodos] PRIMARY KEY CLUSTERED ([IdDia] ASC)
);

