drop table Diario2
go
create table [dbo].[Diario2]
(
[id] int not null primary key identity(1,1),
[nome] varchar(100) not null,
[materia] varchar(50) not null,
[nota1] int not null,
[nota2] int not null,
[nota3] int not null,
[nota4] int not null
)
go
insert into [Diario2]
(nome, materia, nota1, nota2, nota3, nota4)
values
('Felipe', 'Word', 8, 7, 9,9)
go
insert into [Diario2]
(nome, materia, nota1, nota2, nota3,nota4)
values
('Giomar', 'Word', 2, 7, 5,2)
go
select * from Diario2

select temp.nome,((nota1+nota2+nota3+nota4)/4) as media, iif(temp.media >= 7, 'Aprovado','Reprovado') as 'Situacao' from (select *,((nota1+nota2+nota3+nota4)/4) as 'media' from Diario2) temp