
/*drop table livros
go
drop table biblioteca
go
create table [biblioteca]
(
	id int not null primary key identity(1,1),
	nome varchar(100) not null,
	cep varchar(10) not null,
	ativo bit not null default 1,
	UsuInc int not null,
	UsuAlt int not null,
	dataInc datetime not null,
	dataAlt datetime not null	
)
go
create table [livros]
(
	id int not null primary key identity(1,1),
	nome varchar(100) not null,
	autor varchar(100) not null,
	alocado bit not null default 0,
	id_biblioteca int not null,
	UsuInc int not null,
	UsuAlt int not null,
	dataInc datetime not null,
	dataAlt datetime not null,
	constraint [Fk_livros_Biblioteca] foreign key ([id_biblioteca]) references [biblioteca](id)
)
go
insert into biblioteca
(nome,cep,UsuInc,UsuAlt,dataInc,dataAlt)
values
('HBSIS','89.110.430',1,1,GETDATE(), getdate())
go
insert into biblioteca
(nome,cep,UsuInc,UsuAlt,dataInc,dataAlt)
values
('Hiper','89.110.000',1,1,GETDATE(), getdate())
go-- biblioteca 1
insert into livros
(nome,autor,id_biblioteca,UsuInc,UsuAlt,dataInc,dataAlt)
values
('O lobo','Marilia meirelles',1,1,1,GETDATE(), getdate())
go
insert into livros
(nome,autor,id_biblioteca,UsuInc,UsuAlt,dataInc,dataAlt)
values
('A bela','Ronal',1,1,1,GETDATE(), getdate())
go
insert into livros
(nome,autor,id_biblioteca,UsuInc,UsuAlt,dataInc,dataAlt)
values
('A Princesa','Alana Rubert',1,1,1,GETDATE(), getdate())
go -- Biblioteca 2
insert into livros
(nome,autor,id_biblioteca,UsuInc,UsuAlt,dataInc,dataAlt)
values
('Longas tranças da mulher careca','Marilia Mendonça',2,1,1,GETDATE(), getdate())
go
insert into livros
(nome,autor,id_biblioteca,UsuInc,UsuAlt,dataInc,dataAlt)
values
('O Feio','Ronald Trump',2,1,1,GETDATE(), getdate())
go
insert into livros
(nome,autor,id_biblioteca,UsuInc,UsuAlt,dataInc,dataAlt)
values
('Gotan city','Batman Hoof',2,1,1,GETDATE(), getdate())
select * from biblioteca
go
select * from livros*/






select biblioteca.nome, COUNT(livros.nome) as [Quantidade Livros]
	from biblioteca
	inner join livros on biblioteca.id = livros.id_biblioteca 
	group by biblioteca.nome--O Inner traz somente os dados relacionados entre as duas tabela


select 
	b1.nome,
	(select COUNT(*)
	from livros lv
	where lv.id_biblioteca = b1.Id) as [Quantidade]
from biblioteca b1
