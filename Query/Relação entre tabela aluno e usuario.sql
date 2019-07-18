drop table Aluno
go
drop table Usuario
go
create table Usuario
(
	Id int not null primary key identity(1,1),
	Nome varchar(100) not null,
	Ativo bit not null,
	UserInc int not null,
	UserAlt int not null default 0,
	dataInc Datetime not null,
	datAlt Datetime not null
)
go
create table Aluno
(
	Id int not null primary key identity(1,1),
	Nome varchar(100) not null,
	Ativo bit not null,
	UserInc int not null,
	UserAlt int not null default 0,
	dataInc Datetime not null,
	datAlt Datetime not null,
	Constraint [Fk_alunos_UsuarioInc] foreign key([UserInc])	references Usuario ([id]),
	Constraint [Fk_alunos_UsuarioAlt] foreign key([UserAlt])	references Usuario ([id])

)
go
insert into Usuario
(Nome,Ativo,UserInc,UserAlt,dataInc,datAlt)
values
('Admin',1,0,0,GETDATE(),GETDATE())
go
insert into Aluno
(Nome,Ativo,UserInc,UserAlt,dataInc,datAlt)
values
('Gilmar',1,1,1,GETDATE(),GETDATE())
go
select * from Aluno
go
select * from Usuario