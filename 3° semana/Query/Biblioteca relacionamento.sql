drop table LivroAutor
go
drop table Autores
go
drop table Locacao
go
drop table Livros
go
drop table Generos
go
drop table Editoras
go
drop table Usuarios
go

CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Nome] VARCHAR(100) NOT NULL, 
    [Login] VARCHAR(50) NOT NULL, 
    [Senha] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [Ativo] BIT NOT NULL DEFAULT 1, 
    [UsuInc] INT NOT NULL, 
	[UsuAlt] INT NOT NULL, 
    [DataInc] DATETIME NOT NULL DEFAULT getdate(),     
    [DataAlt] DATETIME not NULL DEFAULT getdate()
)
go
CREATE TABLE [dbo].[Editoras]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(1200) NOT NULL, 
    [Descricao] VARCHAR(1000) NULL,
	
)
go
CREATE TABLE [dbo].[Generos]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Tipo] VARCHAR(200) NOT NULL, 
    [Descricao] VARCHAR(1000) NULL,
	
)
go
CREATE TABLE [dbo].[Autores]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Tipo] VARCHAR(200) NOT NULL, 
    [Descricao] VARCHAR(1000) NULL,
	
)
go
CREATE TABLE [dbo].[Livros]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Registro] int not null,
	[Titulo] varchar(1200),
    [Tipo] VARCHAR(200) NOT NULL, 
    [Descricao] VARCHAR(1000) NULL,
	[ISBN] varchar(15) not null,
	[Genero] int not null,
	[Editora] int not null,
	[Sinopse] nvarchar(max) null,	
	[Observacoes] varchar(1000) null,
	[Ativo] bit not null default 1,
	[UsuInc] INT NOT NULL, 
	[UsuAlt] INT NOT NULL, 
    [DataInc] DATETIME NOT NULL DEFAULT getdate(),     
    [DataAlt] DATETIME not NULL DEFAULT getdate(),

	constraint [Fk_Livro_To_Genero] foreign key([Genero]) references Generos([id]),
	constraint [Fk_Livro_To_Editora] foreign key([Editora]) references Editoras([id]),
	constraint [Fk_Livro_To_UsuarioInc] foreign key([UsuInc]) references Usuarios([id]),
	constraint [Fk_Livro_To_UsuarioAlt] foreign key([UsuAlt]) references Usuarios([id]),
	
)
go
create table LivroAutor
(
	Livro int not null,
	Autor int not null,

	constraint [Fk_LivroAutor_To_Livros] foreign key([Livro]) references Livros([id]),
	constraint [Fk_LivroAutor_To_Autores] foreign key([Autor]) references Autores([id])

)
go
CREATE TABLE [dbo].[Locacao]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Livro] int NOT NULL, 
    [Usuario] int NOT NULL,
	[Tipo] int not null,
	[Devolucao] datetime not null default 7, 
	--[Observacao] varchar(500) not null,
    [Ativo] BIT NOT NULL DEFAULT 1, 
    [UsuInc] INT NOT NULL, 
	[UsuAlt] INT NOT NULL, 
    [DataInc] DATETIME NOT NULL DEFAULT getdate(),     
    [DataAlt] DATETIME not NULL DEFAULT getdate()

	constraint [Fk_Locacao_To_Livros] foreign key([Livro]) references [Livros]([id]),
	constraint [Fk_Locacao_To_UsuarioAloc] foreign key([Usuario]) references [Usuarios]([id]),
	constraint [Fk_Locacao_To_UsuarioInc] foreign key([UsuInc]) references [Usuarios]([id]),
	constraint [Fk_Locacao_To_UsuarioAlt] foreign key([UsuAlt]) references [Usuarios]([id])
)