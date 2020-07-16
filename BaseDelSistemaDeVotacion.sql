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
EstadoVotacion varchar(25) not null,
Partido int FOREIGN KEY REFERENCES PartidoPolitico(idPartido)
)


create table Departamento(
idDepartamento varchar(2) not null primary key,
nombreDepartamento varchar(50)
)


create table Municipio(
idMunicipio varchar(2) not null primary key,
nombreMunicipio varchar(50),
idDepartamento varchar(2) FOREIGN KEY REFERENCES Departamento(idDepartamento)
)


create table Alcalde(
idAlcalde int identity primary key not null,
PrimerNombre varchar(25) not null,
SegundoNombre varchar(25),
PrimerApellido varchar(25) not null,
SegundoApellido varchar(25),
VotosValidos int not null,
VotosNulos int,
EstadoVotacion varchar(25) not null,
Partido int FOREIGN KEY REFERENCES PartidoPolitico(idPartido),
Municipio varchar(2) FOREIGN KEY REFERENCES Municipio(idMunicipio)
)

create table Diputado(
idAlcalde int identity primary key not null,
PrimerNombre varchar(25) not null,
SegundoNombre varchar(25),
PrimerApellido varchar(25) not null,
SegundoApellido varchar(25),
VotosValidos int not null,
VotosNulos int,
EstadoVotacion varchar(25) not null,
Partido int FOREIGN KEY REFERENCES PartidoPolitico(idPartido),
Departamento varchar(2) FOREIGN KEY REFERENCES Departamento(idDepartamento)
)

create table votante(
IdentidadVotante varchar(13) primary key not null,
PrimerNombre varchar(25) not null,
SegundoNombre varchar(25) not null,
PrimerApellido varchar(25) not null,
SegundoApellido varchar(25) not null,
edad int not null,
sexo varchar(10) not null,
estadoVotante varchar(25) not null,
CodMunicipio varchar(2) FOREIGN KEY REFERENCES Municipio(idMunicipio)
)

---------------Procedimien-Almacenado----

---------Insertar-Presidente----
create procedure ingresarPresidente 
(
@PrimerNombre varchar(25),
@segundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@EstadoVotacion varchar(25),
@Partido int 
)
as
begin
if exists(select PrimerNombre from Presidente where PrimerNombre=@PrimerNombre and PrimerApellido=@PrimerApellido)
		raiserror('El Presidente ya existe, Ingrese otro',16,1)
else 
		insert into Presidente( PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,EstadoVotacion,Partido)
		values(@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@EstadoVotacion,@Partido)
end

-------Insertar--Alcalde--
create procedure ingresarAlcalde
(
@PrimerNombre varchar(25) ,
@SegundoNombre varchar(25),
@PrimerApellido varchar(25) ,
@SegundoApellido varchar(25),
@EstadoVotacion varchar(25) not null,
@Partido int ,
@Municipio varchar(2)
)
as
begin
if exists(select PrimerNombre from Alcalde where PrimerNombre=@PrimerNombre and PrimerApellido=@PrimerApellido)
		raiserror('El Alcalde ya existe, Ingrese otro',16,1)
else 
		insert into Alcalde( PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,EstadoVotacion,Partido,Municipio)
		values(@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@EstadoVotacion,@Partido,@Municipio)
end
