drop table aulacsharp
go
create table [dbo].[AulaCsharp]
(
	[Id] int not null primary key identity(1,1),
	[Aluno] varchar(100) not null,
	[Idade] int null,
	[Ativo] bit not null,
	[UsuInc] int not null,
	[UsuAlt] int not null,
	[DatInc] date not null,
	[DatAlt] date not null
)
go
insert into dbo.AulaCsharp
(Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Willian',25,1,0,0,getdate(),getdate())
go
insert into dbo.AulaCsharp
(Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Rubes',26,1,0,0,getdate(),getdate())
go
insert into dbo.AulaCsharp
(Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Ana',30,0,0,0,getdate(),getdate())
go
insert into dbo.AulaCsharp
(Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Felipe',27,1,0,0,getdate(),getdate())
go
insert into dbo.AulaCsharp
(Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Chay',19,1,0,0,getdate(),getdate())
go
select * from aulacsharp

update AulaCsharp
set Aluno = 'Giomar',
	Ativo = 1,
	idade = 52,
	DatAlt = getdate()
where Id = 5
go
select 
		aluno,
		idade,
		iif(ativo = 1, 'ativo', 'inativo') as 'status'
from aulacsharp 
	where id in 
		(select id 
	from aulacsharp 
	where idade > 30)
order by Id Desc

update AulaCsharp
	set Aluno = 'Brian',
		idade = 31
where id = 2;

