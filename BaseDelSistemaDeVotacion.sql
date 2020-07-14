create database SistemaNacionalDeElecciones
go

use SistemaNacionalDeElecciones
go

create table PartidoPolitico(
idPartido int identity not null primary key,
NombrePartido varchar(50) not null,
Lema varchar(100)
)

create table Presidente(
idPresidente int identity primary key not null,
PrimerNombre varchar(25) not null,
SegundoNombre varchar(25),
PrimerApellido varchar(25) not null,
SegundoApellido varchar(25),
VotosValidos int not null,
VotosNulos int,
Partido int FOREIGN KEY REFERENCES PartidoPolitico(idPartido)
)
--A donde ira a Votar o desde donde esta votando
create table CentroDeVotacion(
idCentroDeVotacion int not null primary key,
Nombre varchar(45),
Departamento varchar(30),
Municipio varchar(30),
Dirrecion varchar(50)
)
--almacenara todos los departamentos
create table Departamento(
idDepartamento int not null primary key,
nombreDepartamento varchar(50)
)
--almacenara todos los municipios
create table Municipio(
idMunicipio int not null primary key,
nombreMunicipio varchar(50),
idDepartamento varchar(2)
)
