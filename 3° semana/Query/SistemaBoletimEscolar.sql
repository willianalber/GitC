DROP TABLE [dbo].[DIARIO]
go
DROP TABLE [dbo].[Alunos]
go
DROP TABLE [dbo].[Turmas]
go
CREATE TABLE [dbo].[Turmas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Descricao] NVARCHAR(100) NOT NULL, 
)
go
CREATE TABLE [dbo].[Alunos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nome] NVARCHAR(100) NOT NULL, 
    [Turma] int NOT NULL,

	CONSTRAINT [fK_Aluno_To_Turma] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turmas]([id])
)
go
go
CREATE TABLE [dbo].[Diario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Aluno] int NOT NULL,
	[Frequencia] INT not null, -- coloquei esse campo como inteiro pois no futuro o sistema possa ser implemenado 0 faltou, 1- presente 3-falta justificada...
	[Nota] float NOT NULL DEFAULT 0,

	CONSTRAINT [fK_Diario_To_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos]([id])
	
)
go
insert into [dbo].[Turmas]-- Inserção das turmas
(Descricao)
values
('3°ano B')
go
insert into [dbo].[Turmas]
(Descricao)
values
('3°ano A')
go
select * from [dbo].[Turmas]
go
insert into [dbo].[Alunos]--Inserção dos alunos
(Nome,Turma)
values
('Willian',1)
go
insert into [dbo].[Alunos]
(Nome,Turma)
values
('Gabriel',1)
go
insert into [dbo].[Alunos]
(Nome,Turma)
values
('Jeferson',1)
go
insert into [dbo].[Alunos]
(Nome,Turma)
values
('Cristiano',2)
go
insert into [dbo].[Alunos]
(Nome,Turma)
values
('Ruan',2)
go
select * from Alunos
go
insert into [dbo].[Diario]--Inserção das notas e frequencia
(Aluno,Frequencia,Nota) 
values
(1,1,9)
go
insert into [dbo].[Diario] -- aluno 1 2º NOTA
(Aluno,Frequencia,Nota)
values
(1,1,8)
go
insert into [dbo].[Diario] -- aluno 1 3º NOTA
(Aluno,Frequencia,Nota)
values
(1,1,7)
go
insert into [dbo].[Diario] -- aluno 1 4º NOTA
(Aluno,Frequencia,Nota)
values
(1,1,6)
go
insert into [dbo].[Diario] -- aluno 2 1º NOTA
(Aluno,Frequencia,Nota)
values
(2,1,6)
go
insert into [dbo].[Diario] -- aluno 2 2º NOTA
(Aluno,Frequencia,Nota)
values
(2,1,5)
go
insert into [dbo].[Diario] -- aluno 2 3º NOTA
(Aluno,Frequencia,Nota)
values
(2,1,5)
go
insert into [dbo].[Diario] -- aluno 2 4º NOTA
(Aluno,Frequencia,Nota)
values
(2,1,6)
go
insert into [dbo].[Diario] -- aluno 3 1º NOTA
(Aluno,Frequencia,Nota)
values
(3,0,8)
insert into [dbo].[Diario] -- aluno 3 2º NOTA
(Aluno,Frequencia,Nota)
values
(3,0,8)
go
insert into [dbo].[Diario] -- aluno 3 3º NOTA
(Aluno,Frequencia,Nota)
values
(3,0,8)
go
insert into [dbo].[Diario] -- aluno 3 4º NOTA
(Aluno,Frequencia,Nota)
values
(3,1,8)
go
insert into [dbo].[Diario] -- aluno 4 1º NOTA
(Aluno,Frequencia,Nota)
values
(4,0,8)
insert into [dbo].[Diario] -- aluno 4 2º NOTA
(Aluno,Frequencia,Nota)
values
(4,0,8)
go
insert into [dbo].[Diario] -- aluno 4 3º NOTA
(Aluno,Frequencia,Nota)
values
(4,0,8)
go
insert into [dbo].[Diario] -- aluno 4 4º NOTA
(Aluno,Frequencia,Nota)
values
(4,1,8)
go
insert into [dbo].[Diario] -- aluno 5 1º NOTA
(Aluno,Frequencia,Nota)
values
(5,0,8)
insert into [dbo].[Diario] -- aluno 5 2º NOTA
(Aluno,Frequencia,Nota)
values
(5,1,8)
go
insert into [dbo].[Diario] -- aluno 5 3º NOTA
(Aluno,Frequencia,Nota)
values
(5,1,8)
go
insert into [dbo].[Diario] -- aluno 5 4º NOTA
(Aluno,Frequencia,Nota)
values
(5,1,8)
go
insert into [dbo].[Diario] -- aluno 5 5º NOTA
(Aluno,Frequencia,Nota)
values
(5,1,8)
go
insert into [dbo].[Diario] -- aluno 5 6º NOTA
(Aluno,Frequencia,Nota)
values
(5,1,4)
go
select * from Diario

go
select
	Temp.Id,
	Temp.Aluno, --Retorna o nome do aluno na coluna
	Temp.Turma, --Retorna a descrição da turma vinculada ao aluno
	round(avg(d.Nota),2) as 'media', -- retorna a média somando todas as notas vinculadas ao aluno e dividindo pela quantidade
	(sum(d.frequencia) * 100)/ count(d.frequencia) as 'frequecia (%)',--Retorna a frequencia somando os valores onde 1 representa presente e 0 que o aluno faltou, 																	 
	iif (avg(d.Nota) >= 7 and (sum(d.frequencia) * 100)/ count(d.nota) >= 75, 'Aprovado','Reprovado')  as 'Situacao' 
from 
	(select 
		al.Id,
		Al.Nome as 'Aluno', 
		t.Descricao as 'Turma' 
	from Alunos Al 
		inner join Turmas T on Al.Turma = t.Id) Temp -- Tabela Temp contem o |ID de aluno | nome | Descricao da turma
	inner join Diario d on Temp.Id = d.Aluno
Group by Temp.Id, temp.Aluno,Temp.Turma
order by [frequecia (%)] asc