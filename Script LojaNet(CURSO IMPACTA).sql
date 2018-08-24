/*
CREATE DATABASE LojaNetDb
GO
USE LojaNetDb
GO
CREATE TABLE Cliente(
	Id varchar(50) primary key,
	Nome varchar(100),
	Email varchar(100),
	Telefone varchar(100)
)

GO

CREATE PROCEDURE ClienteIncluir(
	@Id varchar(50),
	@Nome varchar(100),
	@Email varchar(100),
	@Telefone varchar(100)
)
    as
INSERT INTO Cliente(Id, Nome, Email, Telefone)
	VALUES(@Id, @Nome, @Email, @Telefone)

GO

CREATE PROCEDURE ClienteListar
	as
SELECT Id, Nome, Email, Telefone FROM Cliente


GO 

CREATE PROCEDURE ClienteExcluir(
	@Id varchar(50)
)
	as
DELETE FROM Cliente WHERE Id=@Id

*/

GO

CREATE PROCEDURE ClienteObterPorId(
	@Id varchar(50)
)
	as
SELECT Id, Nome, Email, Telefone
FROM Cliente
WHERE Id=@Id

GO

CREATE PROCEDURE ClienteAlterar(
	@Id varchar(50),
	@Nome varchar(100),
	@Email varchar(100),
	@Telefone varchar(100)
)
	as
UPDATE Cliente
SET Nome=@Nome, Email=@Email, Telefone=@Telefone
WHERE Id=@Id