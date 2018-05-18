CREATE DATABASE LibrosDb
GO
USE LibrosDb
GO
CREATE TABLE Libros
(
	LibroId int primary key identity, 
	Descripcion varchar(max),
	Siglas varchar(max),
);

drop table Libros;