drop table  [dbo].[FoodTruck]
go
create table [dbo].[FoodTruck]
(
	id int not null primary key identity(1,1),
	Tipo varchar(50) not null,
	TotalDeVendas int not null,
	dataVenda date not null
)
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Egg', 10, '2019-07-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog da Casa', 25, '2019-07-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Soya', 90, '2019-07-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Egg', 80, '2019-07-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog da Casa', 40, '2019-07-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Soya', 20, '2019-7-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Egg', 10, '2019-07-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog da Casa', 25, '2019-07-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Soya', 90, '2019-07-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Egg', 80, '2019-07-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog da Casa', 40, '2019-07-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Soya', 20, '2019-7-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Egg', 14, '2019-06-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog da Casa', 13, '2019-06-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Soya', 41, '2019-06-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Egg', 54, '2019-06-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog da Casa', 57, '2019-06-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Soya', 29, '2019-06-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Egg', 30, '2019-06-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog da Casa', 12, '2019-06-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Soya', 15, '2019-06-05')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Egg', 60, '2019-06-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog da Casa', 80, '2019-06-06')
go
insert into [dbo].[FoodTruck]
(Tipo, TotalDeVendas, dataVenda)
values
('Dog Soya', 12, '2019-06-06')
go
select * from FoodTruck
go
select * from 
(
	select 
		tipo, 
		month(dataVenda) as 'Mês' ,
		sum(TotalDeVendas) as 'Total de vendas'
	from FoodTruck
	group by Tipo, month(dataVenda)
)
temp order by temp.[Total de vendas] desc



