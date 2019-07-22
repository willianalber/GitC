CREATE TABLE [dbo].[Usuarios] ( --
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Turmas] ( --
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
    [Obs]    VARCHAR (250) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Turmas_ToUsuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Turmas_ToUsuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);




CREATE TABLE [dbo].[TurmaAlunos] (--
    [Turma] INT NOT NULL,
    [Aluno] INT NOT NULL,
    CONSTRAINT [FK_TurmaAlunos_ToTurmas] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas] ([Id]),
    CONSTRAINT [FK_TurmaAlunos_ToAlunos] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);





CREATE TABLE [dbo].[Presenca] ( --
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [Diario] INT NOT NULL,
    [Aluno]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Presenca_Diarios] FOREIGN KEY ([Diario]) REFERENCES [dbo].[Diarios] ([Id]),
    CONSTRAINT [FK_Presenca_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UC_Presenca_Insert] --
    ON [dbo].[Presenca]([Diario] ASC, [Aluno] ASC);






CREATE TABLE [dbo].[Notas] ( --
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Diario] INT            NOT NULL,
    [Nota]   NUMERIC (5, 2) NOT NULL,
    [Aluno]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Nota_ToDiarios] FOREIGN KEY ([Diario]) REFERENCES [dbo].[Diarios] ([Id]),
    CONSTRAINT [FK_Nota_ToAluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);







CREATE TABLE [dbo].[Diarios] ( --
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Data]   DATETIME      DEFAULT (getdate()) NOT NULL,
    [Turma]  INT           NOT NULL,
    [Obs]    VARCHAR (500) NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Diario_ToTurmas] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas] ([Id]),
    CONSTRAINT [FK_Diario_ToUsuInc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Diario_ToUsuAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);


CREATE TABLE [dbo].[Alunos] (--
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Alunos] VARCHAR (100) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alunos_ToUsuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Alunos_ToUsuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuarios] ([Id])
);