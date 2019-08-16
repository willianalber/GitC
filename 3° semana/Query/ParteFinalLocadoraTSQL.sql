/*create database [ParteFinalLocadoraTSQL]
go
use [ParteFinalLocadoraTSQL]
go */
drop table estoque
go
drop table locacao
go
go
drop table carros
go
drop table clientes
go
drop table usuario
go
create table [Usuario]
(
    [Id]     INT           Primary key IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (100) NOT NULL,
	[Senha]	 varchar(50) not null,
    [Ativo]    BIT           NOT NULL default 1,
    --[UsuInc]   INT           NOT NULL default 1,
    --[UsuAlt]   INT           NOT NULL default 1  ,
    --[DatInc]   DATETIME      NOT NULL default getdate(),          
    --[DatAlt]   DATETIME      NOT NULL default getdate(),
)
go
insert into Usuario
(nome,Senha)
values
('Admin','admin')
go
Create table [Clientes]
(
	[Id]       INT           Primary key IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (100) NOT NULL,
	[Endereco] VARCHAR (100) NOT NULL, 
    [Ativo]    BIT           NOT NULL default 1,
    [UsuInc]   INT           NOT NULL default 1,
    [UsuAlt]   INT           NOT NULL default 1  ,
    [DatInc]   DATETIME      NOT NULL default getdate(),          
    [DatAlt]   DATETIME      NOT NULL default getdate(),
	CONSTRAINT [Fk_Clientes_UsuInc]	   foreign key ([UsuInc])    References [Usuario]([id]),
	CONSTRAINT [Fk_Clientes_UsuAlt]	   foreign key ([UsuAlt])	 References [Usuario]([id]),
)
go
insert into [Clientes]
(Nome, Endereco)
Values
('Willian','Rua Manoel B da Silva')
go
insert into [Clientes]
(Nome, Endereco)
Values
('Gabriel','Modesto Silva')
go
create table [Carros]
(
	[Id]       INT           Primary key IDENTITY (1, 1) NOT NULL,
    [Modelo]   VARCHAR (100) NOT NULL,
	[Marca]	   VARCHAR (100) NOT NULL, 
    [Ativo]    BIT           NOT NULL default 1,
    [UsuInc]   INT           NOT NULL default 1,
    [UsuAlt]   INT           NOT NULL default 1  ,
    [DatInc]   DATETIME      NOT NULL default getdate(),          
    [DatAlt]   DATETIME      NOT NULL default getdate(),
	CONSTRAINT [Fk_Carros_UsuInc]	   foreign key ([UsuInc])    References [Usuario]([id]),
	CONSTRAINT [Fk_Carros_UsuAlt]	   foreign key ([UsuAlt])	 References [Usuario]([id]),
)
go
insert into Carros
(Modelo, Marca)
values
('Golf', 'Volkswagen')
go
insert into Carros
(Modelo, Marca)
values
('Celta', 'Chevrolet')
go
insert into Carros
(Modelo, Marca)
values
('Chevet', 'Chevrolet')
go
create table [estoque]
(
	[IdCarro]  INT			 NOT NULL,
    [Qtdade]   INT  		 NOT NULL,
    [Ativo]    BIT           NOT NULL default 1,
    [UsuInc]   INT           NOT NULL default 1,
    [UsuAlt]   INT           NOT NULL default 1  ,
    [DatInc]   DATETIME      NOT NULL default getdate(),          
    [DatAlt]   DATETIME      NOT NULL default getdate(),
	CONSTRAINT [Fk_Estoque_to_Carro]   foreign key ([IDCarro])   References [Carros]([id]),
	CONSTRAINT [Fk_Estoque_UsuInc]	   foreign key ([UsuInc])    References [Usuario]([id]),
	CONSTRAINT [Fk_Estoque_UsuAlt]	   foreign key ([UsuAlt])	 References [Usuario]([id]),
)
go
create unique nonclustered index [UC_Estoque_Carros]
on [estoque]([IdCarro])
go
insert into estoque
(IdCarro,Qtdade)
values
(1,10)
go
insert into estoque
(IdCarro,Qtdade)
values
(2,20)
go
create table [Locacao]
(
	[Id]			 INT           Primary key IDENTITY (1, 1) NOT NULL,
	[IDCliente]		 INT		   NOT NULL,
    [IDCarro]		 INT  		   NOT NULL,
    [Data]			 DATETIME	   NOT NULL,
	[Ativo]    BIT           NOT NULL default 1,
    [UsuInc]   INT           NOT NULL default 1,
    [UsuAlt]   INT           NOT NULL default 1  ,
    [DatInc]   DATETIME      NOT NULL default getdate(),          
    [DatAlt]   DATETIME      NOT NULL default getdate(),
	CONSTRAINT [Fk_LocacaoCliente] foreign key ([IDCliente]) References [Clientes]([id]),
	CONSTRAINT [Fk_LocacaoCarro]   foreign key ([IDCarro])   References [Carros]([id]),
	CONSTRAINT [Fk_LocacaoUsuInc]  foreign key ([UsuInc])    References [Usuario]([id]),
	CONSTRAINT [Fk_LocacaoUsuAlt]  foreign key ([UsuAlt])	 References [Usuario]([id]),
)
go
insert into Locacao
(IDCliente,IDCarro,[Data])
values
(1,1,getdate())
go
insert into Locacao
(IDCliente,IDCarro,[Data])
values
(1,1,'2019/05/01')
go
insert into Locacao
(IDCliente,IDCarro,[Data])
values
(1,1,'2019/06/01')
go
insert into Locacao
(IDCliente,IDCarro,[Data])
values
(1,1,'2019/06/01')
go
insert into Locacao
(IDCliente,IDCarro,[Data])
values
(1,2,'2018/01/01')
go
insert into Locacao
(IDCliente,IDCarro,[Data])
values
(1,2,'2018/10/01')
go
insert into Locacao
(IDCliente,IDCarro,[Data])
values
(1,3,'2019/10/01')
go
-- Relatório do carro que mais foi alocado anual
select	YEAR(l.Data) as 'Ano',
		MAX(C.Modelo) as 'Modelo',
		c.Marca,
		e.Qtdade as 'Estoque'
		from Locacao L
inner join Carros C on L.IDCarro = C.id
right join estoque E on C.Id = e.IdCarro
group by YEAR(l.Data),c.Marca, e.Qtdade
go
-- Relatório de carros alocados por mês
select 
	MONTH(l.[Data]) as 'Mês',
	C.Marca,
	C.Modelo,
	COUNT(l.[Data]) as 'Qtd Locado'		
from Locacao L
	inner join Carros C on L.IDCarro = C.id
group by
	C.Marca,
	C.Modelo, 
	MONTH(l.[Data]) 
order by
	MONTH(l.[Data]) asc
go
-- Relatório de carros alocados por ano
select 
	year(l.[Data]) as 'Ano',
	C.Marca,
	C.Modelo,
	COUNT(l.[Data]) as 'Qtd Locado'		
from Locacao L
	inner join Carros C on L.IDCarro = C.id
group by
	C.Marca,
	C.Modelo, 
	year(l.[Data]) 
order by
	year(l.[Data]) asc