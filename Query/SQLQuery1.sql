insert into SacolaDaCooper
(CaixaCafe,Leite,CervejaLong,CervejaLata,CervejaBarril)
values
(10,5,8,3,6);
go
select * from dbo.sacoladacooper

update SacolaDaCooper set Acucar = 2 where Acucar is null