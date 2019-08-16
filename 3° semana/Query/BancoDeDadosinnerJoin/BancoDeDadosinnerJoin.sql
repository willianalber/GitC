

select Nome from [Marcas] 
where UsuInc = (select Id from [Usuarios] 
				where Usuario = 'Felipe') -- Trazer somente as marcas que Felipe cadastrou

select Nome from [Marcas] 
where UsuInc = (select Id from [Usuarios] 
				where Usuario = 'Giomar') -- Trazer somente as marcas que Giomar cadastrou

select count(*) as 'Quantidade' from [Marcas] 
where UsuInc = (select Id from [Usuarios]	
				where Usuario = 'Felipe') order by 'Quantidade' desc-- Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor

select count(*) as 'Quantidade' from [Marcas] 
where UsuInc = (select Id from [Usuarios] 
				where Usuario = 'Giomar') order by 'Quantidade' Asc -- Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior

select count(*) as 'Quantidade' from [Marcas] 
where UsuInc in (select Id from [Usuarios] 
				 where Usuario in ('Giomar','Felipe')) --Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram

select * from Carros 
where UsuInc = (select Id from [Usuarios] 
				where Usuario = 'Felipe') --Trazer somente os carros que Felipe cadastrou

select * from Carros 
where UsuInc = (select Id from [Usuarios] 
				where Usuario = 'Giomar') --Trazer somente os carros que Giomar cadastrou

select count(*) as 'Quantidade de Felipe' from [Carros] 
where UsuInc = (select Id from [Usuarios]	
				where Usuario = 'Felipe') order by 'Quantidade de Felipe' desc --Trazer somente a quantidade de carros que Felipe cadastrou maior para menor

select count(*) as 'Quantidade de Gilmar' from [Carros] 
where UsuInc = (select Id from [Usuarios]	
				where Usuario = 'Giomar') order by 'Quantidade de Gilmar' asc --Trazer somente a quantidade de carros que Giomar cadastrou menor para maior

select count(*) as 'Quantidade Gilmar e Felipe' from [Carros] 
where UsuInc in (select Id from [Usuarios] 
				 where Usuario in ('Giomar','Felipe'))--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram  

select * from Carros
where Carros.Marca in (select id from [Marcas] 
					   where UsuInc = (select Id from [Usuarios]
									   where Usuario = 'Felipe'))--Trazer somente os carros das marcas que Felipe cadastrou

select 
	C.id, 
	c.Modelo, 
	m.Nome as 'Marca', 
	c.Ano 
from 
	Carros C 
inner join 
	Marcas M on C.Marca = M.Id
inner join 
	Usuarios U on M.UsuInc = u.Id 
where u.Usuario = 'Felipe'			--Trazer somente os carros das marcas que Felipe cadastrou


select * from Carros
where Carros.Marca in (select id from [Marcas] 
					   where UsuInc = (select Id from [Usuarios]
									   where Usuario = 'Giomar'))--Trazer somente os carros das marcas que Giomar cadastrou

select 
	C.id, 
	c.Modelo, 
	m.Nome as 'Marca', 
	c.Ano 
from 
	Carros C 
inner join 
	Marcas M on C.Marca = M.Id
inner join 
	Usuarios U on M.UsuInc = u.Id 
where u.Usuario = 'Giomar'			--Trazer somente os carros das marcas que Giomar cadastrou

select 
	u.Usuario,
	COUNT(c.Modelo) as 'Quantidade de carros cadastrado'
from 
	Carros C 
inner join 
	Marcas M on C.Marca = M.Id
inner join 
	Usuarios U on M.UsuInc = u.Id 
where u.Usuario = 'Felipe'
group by u.Usuario
order by 'Quantidade de carros cadastrado' desc	--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor

select 
	u.Usuario,
	COUNT(c.Modelo) as 'Quantidade de carros cadastrado'
from 
	Carros C 
inner join 
	Marcas M on C.Marca = M.Id
inner join 
	Usuarios U on M.UsuInc = u.Id 
where u.Usuario = 'Giomar'
group by u.Usuario
order by 'Quantidade de carros cadastrado' asc --Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior

select sum(v.Valor) as 'Total de vendas no ano de 2019' from Vendas v where YEAR(v.DatInc) = 2019 --Trazer o valor total de vendas 2019 isolado

select 
	count(*) as 'Quantidade de vendas', 
	sum(v.Valor) as 'Total de vendas no ano de 2019' 
from 
	Vendas v 
where 
	YEAR(v.DatInc) = 2019 --Trazer a quantidade total de vendas 2019 isolado

select 
	YEAR(v.DatInc) as 'Ano',
	sum(v.Valor) as 'Total de vendas' 
from 
	Vendas v 
group by YEAR(v.DatInc)
order by 'Total de vendas' desc --Trazer o valor total de vendas em cada ano e ordernar do maior para o menor

select 
	YEAR(v.DatInc) as 'Ano',
	count(v.Valor) as 'Quantidade de vendas' 
from 
	Vendas v 
group by YEAR(v.DatInc)
order by 'Quantidade de vendas' desc --Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor


select 
	YEAR(v.DatInc) as 'Ano', 
	MONTH(v.DatInc) as 'Mês', 
	count(v.Valor) as 'Quantidade' 
from 
	Vendas V 
group by YEAR(v.DatInc), MONTH(v.DatInc)
order by Quantidade desc			--Trazer o mês de cada ano que retornou a maior quantidade de vendas
									-- Tradução "Retornar agrupado por mês e ordernar do maior para menor"

select 
	YEAR(v.DatInc) as 'Ano', 
	MONTH(v.DatInc) as 'Mês', 
	sum(v.Valor) as 'Total de vendas' 
from 
	Vendas V 
group by YEAR(v.DatInc), MONTH(v.DatInc)
order by sum(v.Valor) desc				--Trazer o mês de cada ano que retornou o maior valor de vendas
										-- Tradução "Retornar agrupado por mês e ordernar do maior para menor"

select 
	u.Usuario as 'Vendedor',
	sum(v.Valor) as 'Total de vendas'
from 
	Vendas V 
inner join 
	Usuarios U on V.UsuInc = u.Id 
where 
	u.Id = (select Id from [Usuarios]	
			where Usuario = 'Felipe')
group by
	u.Usuario					--Trazer o valor total de vendas que Felipe realizou


select 
	u.Usuario as 'Vendedor',
	sum(v.Valor) as 'Total de vendas'
from 
	Vendas V 
inner join 
	Usuarios U on V.UsuInc = u.Id 
where 
	u.Id = (select Id from [Usuarios]	
			where Usuario = 'Giomar')
group by
	u.Usuario					--Trazer o valor total de vendas que Giomar realizou

select 
	u.Usuario as 'Vendedor',
	count(v.Valor) as 'Quantidade Total de vendas'
from 
	Vendas V 
inner join 
	Usuarios U on V.UsuInc = u.Id 
where 
	u.Id = (select Id from [Usuarios]	
			where Usuario = 'Felipe')
group by
	u.Usuario					--Trazer a quantidade total de vendas que Felipe realizou

select 
	u.Usuario as 'Vendedor',
	count(v.Valor) as 'Quantidade Total de vendas'
from 
	Vendas V 
inner join 
	Usuarios U on V.UsuInc = u.Id 
where 
	u.Id = (select Id from [Usuarios]	
			where Usuario = 'Giomar')
group by
	u.Usuario				--Trazer a quantidade de vendas que Giomar realizou


select 
	u.Usuario as 'Vendedor',
	count(v.Valor) as 'Quantidade Total de vendas'
from 
	Vendas V 
inner join 
	Usuarios U on V.UsuInc = u.Id 
where 
	u.Id in (select Id from [Usuarios]	
			where Usuario in ('Felipe','Giomar'))
group by
	u.Usuario
order by count(v.Valor) desc --Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor


select 
	u.Usuario as 'Vendedor',
	sum(v.Valor) as 'Valor Total de vendas'
from 
	Vendas V 
inner join 
	Usuarios U on V.UsuInc = u.Id 
where 
	u.Id in (select Id from [Usuarios]	
			where Usuario in ('Felipe','Giomar'))
group by
	u.Usuario
order by sum(v.Valor) desc -- Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor

select 
	year(v.DatInc) as 'Ano', 
	m.Nome, 
	v.Valor	 
from 
	Marcas M 
inner join 
	Carros C on M.Id = c.Marca 
inner join 
	Vendas V on C.Id = v.Carro
order by v.Valor desc				--Trazer  a marca mais vendida de todos os anos
									-- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"

select 
	year(v.DatInc) as 'Ano', 
	m.Nome, 
	sum(v.Valor) as 'Total de vendas no ano' 	 
from 
	Marcas M 
inner join 
	Carros C on M.Id = c.Marca 
inner join 
	Vendas V on C.Id = v.Carro
group by year(v.DatInc), m.Nome
order by sum(v.Valor) desc			--Trazer o valor total da marca mais vendida de todos os anos


select 
	year(v.DatInc) as 'ano', 
	c.modelo, 
	sum(v.Quantidade) as 'Quantidade total vendido' 
from 
	carros C 
inner join 
	Vendas v on c.Id = v.Carro
group by 
	year(v.DatInc),
	c.Modelo
order by
	sum(v.Quantidade) desc			--Trazer a quantidade do carro mais vendido de todos os anos


select 
	year(v.DatInc) as 'ano', 
	c.modelo, 
	sum(v.Valor*v.Quantidade) as 'Valor total vendido' 
from 
	carros C 
inner join 
	Vendas v on c.Id = v.Carro
group by 
	year(v.DatInc),
	c.Modelo
order by
	sum(v.Valor*v.Quantidade) desc   --Trazer o valor do carro mais vendido de todos os anos




					