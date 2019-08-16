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
(2018,'Celta', 5,'2018-05-09')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2017,'Palio', 4,'2017-08-05')
go
insert into [carro]
(ano, modelo, numeroVendas, dataVenda)
values
(2019,'Fusca', 2,'2019-06-12')

select * from carro
go
select year(dataVenda) as ano, (sum(numeroVendas)/COUNT(numeroVendas)) as 'media de vendas no ano' from carro group by year(dataVenda)