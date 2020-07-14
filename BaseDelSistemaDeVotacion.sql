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