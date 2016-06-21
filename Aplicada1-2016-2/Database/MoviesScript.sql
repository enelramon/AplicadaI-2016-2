CREATE TABLE  Categorias (
	 CategoriaId int primary key IDENTITY(1,1),
	Descripcion nvarchar(50))
go
 
CREATE TABLE Peliculas(
	PeliculaId int primary key IDENTITY(1,1),
	Titulo nvarchar(100) ,
	Descripcion nvarchar(200) ,
	Ano int ,
	Clasificacion int,
	IMDB int ,
	CategoriaId int  REFERENCES  Categorias (CategoriaId) )
	 
	go

Create table Autores (AutorId int Primary key identity(1,1),
Nombres nvarchar(100))

go

 
Create Table PeliculasAutores(Id int Primary key Identity(1,1),
PeliculaId int references Peliculas(PeliculaId),
AutorId int References Autores(AutorId))