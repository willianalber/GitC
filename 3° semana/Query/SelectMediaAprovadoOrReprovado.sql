drop table [dbo].[Diario]
go
create table [dbo].[Diario]
(
[id] int not null primary key identity(1,1),
[nome] varchar(100) not null,
[materia] varchar(50) not null,
[nota1] int not null,
[nota2] int not null,
[nota3] int not null,
[media] as ((nota1+nota2+nota3)/3),
[status] as iif(((nota1+nota2+nota3)/3) >= 7, 'Aprovado','Reprovado')
)
go
insert into [Diario]
(nome, materia, nota1, nota2, nota3)
values
('Felipe', 'Paint3D', 8, 7, 9)
go
insert into [Diario]
(nome, materia, nota1, nota2, nota3)
values
('Giomar', 'Paint3D', 2, 7, 5)
go
select * from [Diario]

select temp.*,iif(temp.Media >= 7,'Aprovado','Reprovado') as 'Status' from
	(select
		nome,
		materia,
		((nota1+nota2+nota3)/3) as 'media'
	from diario) temp;
select
		nome,
		materia,
		((nota1+nota2+nota3)/3) as 'media',
		iif(((nota1+nota2+nota3)/3) >= 7, 'Aprovado','Reprovado') 
		as 'Status'
from Diario


