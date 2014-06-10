CREATE TABLE [dbo].[Aluno] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (50)  NULL,
    [Telefone] INT           NULL,
    [Altura]   FLOAT (53)    NULL,
    [Aprovado] NVARCHAR (50) NULL,
    [Email]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Nome] ASC)
);