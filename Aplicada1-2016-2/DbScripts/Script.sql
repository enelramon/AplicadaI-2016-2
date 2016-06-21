Create Database Aplicada1Db;
go
use Aplicada1Db;
go

Create Table Clientes (Id int identity(1,1) primary key,
Nombres Varchar(50),
Balance float);


Insert into Clientes (Nombres,Balance) values ('Hugo',1000);
Insert into Clientes (Nombres,Balance) values ('Junior',100.50);
Insert into Clientes (Nombres,Balance) values ('Cesar',500.95);


select * from Clientes where Balance > 600 or  Balance < 101


CREATE TABLE Categorias (
	CategoriaId INT IDENTITY PRIMARY KEY,
	Descripcion VARCHAR(200) NOT NULL
)

CREATE TABLE Peliculas (
	PeliculaId INT IDENTITY PRIMARY KEY,
	Titulo VARCHAR(200) NOT NULL,
	Descripcion VARCHAR(200) NOT NULL,
	Ano INT NOT NULL,
	Clasificacion INT NOT NULL,
	IMDB INT NOT NULL,
	CategoriaId INT FOREIGN KEY REFERENCES Categorias(CategoriaId) NOT NULL
)