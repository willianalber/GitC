drop table [NotaAluno]
go
create table [dbo].[NotaAluno]
(
[id] int not null primary key identity(1,1),
[nome] varchar(100) not null,
[materia] varchar(50) not null,
[nota] int not null,
)
go
insert into NotaAluno
(nome,materia,nota)
values
('Willian','Matematica',10)
go
insert into NotaAluno
(nome,materia,nota)
values
('Cristiano','Matematica',5)
go
insert into NotaAluno
(nome,materia,nota)
values
('Mario','Matematica',3)
go
insert into NotaAluno
(nome,materia,nota)
values
('Giomar','Matematica',8)
go
insert into NotaAluno
(nome,materia,nota)
values
('Amarildo','Matematica',6)
go
insert into NotaAluno
(nome,materia,nota)
values
('Amarildo','Matematica',6)
go
select nome, materia, nota, sum(nota) as soma, SUM(nota)/COUNT(nota) as media, AVG(nota) as media_com_AVG from NotaAluno group by nome,materia, nota