drop table [dbo].[carro]
go
create table [dbo].[carro]
(
	id int  not null primary key identity(1,1),
	modelo varchar(50) not null,
	ano int  not null,
	numeroVendas int not null,
	dataVenda date not null
)
go 
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2018,'Celta', 15,'2018-05-09')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2017,'Palio', 10,'2017-08-05')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Fusca', 13,'2019-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Celta', 16,'2019-05-08')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2018,'Palio', 12,'2018-08-05')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(1992,'Fusca', 40,'2000-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2014,'Celta', 10,'2014-05-09')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2011,'Palio', 1,'2011-04-05')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2013,'Fusca', 11,'2013-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2012,'Celta', 5,'2012-05-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2017,'Palio', 10,'2017-08-05')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Fusca', 13,'2019-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2018,'Celta', 15,'2018-05-09')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2017,'Palio', 10,'2017-08-05')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Fusca', 13,'2019-06-12')
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Fusca', 13,'2019-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2018,'Celta', 15,'2018-05-09')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2017,'Palio', 10,'2017-08-05')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Fusca', 13,'2019-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Fusca', 13,'2019-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2018,'Celta', 15,'2019-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2017,'Palio', 10,'2019-06-12')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Fusca', 26,'2019-06-12')
go
select * from carro
go
select modelo, year(dataVenda) as ano, (sum(numeroVendas)/COUNT(numeroVendas)) as 'media de vendas no ano' from carro group by modelo,  year(dataVenda)

