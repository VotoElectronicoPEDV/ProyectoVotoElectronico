create database SistemaNacionalDeElecciones
go

use SistemaNacionalDeElecciones
go

create table PartidoPolitico(
idPartido int identity not null primary key,
NombrePartido varchar(50) not null,
Lema varchar(100)
)
--insert into PartidoPolitico (NombrePartido,lema)
--values('Partido Nacional','Vamos hacer lo que tengamos que hacer')

create table Presidente(
idPresidente int identity primary key not null,
PrimerNombre varchar(25) not null,
SegundoNombre varchar(25),
PrimerApellido varchar(25) not null,
SegundoApellido varchar(25),
VotosValidos int not null,
VotosNulos int,
Estado varchar(25) not null,
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
DescripcionVotacion varchar(25) not null,
Estado varchar(25) not null,
Partido int FOREIGN KEY REFERENCES PartidoPolitico(idPartido),
Municipio varchar(2) FOREIGN KEY REFERENCES Municipio(idMunicipio)
)

create table Diputado(
idDiputado int identity primary key not null,
PrimerNombre varchar(25) not null,
SegundoNombre varchar(25),
PrimerApellido varchar(25) not null,
SegundoApellido varchar(25),
VotosValidos int not null,
VotosNulos int,
Estado varchar(25) not null,
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

---------------Procedimientos-Almacenados----

---------Insertar-Presidente----
create procedure ingresarPresidente(
@PrimerNombre varchar(25),
@segundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@Estado varchar(25),
@Partido int 
)
as
begin
if exists(select PrimerNombre from Presidente where PrimerNombre=@PrimerNombre and PrimerApellido=@PrimerApellido)
	raiserror('El Presidente ya existe, Ingrese otro',16,1)
else 
	insert into Presidente( PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,Estado,Partido)
	values(@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@Estado,@Partido)
end

--exec ingresarPresidente 'Juan','Orlando','Hernandez','Ratero','activo',1
select * from Presidente

---------Actualizar-Presidente----
create procedure actualizarPresidente(
@idPresidente int,
@PrimerNombre varchar(25),
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@partido int
)
as 
begin
update Presidente 
set PrimerNombre =@PrimerNombre, SegundoNombre = @segundoNombre, PrimerApellido = @PrimerApellido,SegundoApellido = @SegundoApellido, Partido = @partido
where idPresidente =@idPresidente
end

---------Eliminar-Presidente----
create procedure eliminarPresidente(
@idPresidente int
)
as
begin
if exists(select estado,idPresidente from Presidente where idPresidente = @idPresidente and Estado='eliminado')
	raiserror ('el Presidente no existe en la base de datos',16,1)
else
	update Presidente
	set Estado = 'eliminado'
end
exec eliminarPresidente 1

---------consultar-Presidente----
create procedure consultarPresidente
as
begin
select idPresidente as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', p.NombrePartido as 'Partido Politico' from Presidente
inner join PartidoPolitico p on Partido= p.idPartido
end

-------Insertar--Alcalde--
create procedure ingresarAlcalde
(
@PrimerNombre varchar(25) ,
@SegundoNombre varchar(25),
@PrimerApellido varchar(25) ,
@SegundoApellido varchar(25),
@EstadoVotacion varchar(25),
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

----------insertar Diputado--------

create procedure ingresarDiputado(
@PrimerNombre varchar(25),
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),	
@SegundoApellido varchar(25),
@EstadoVotacion varchar(25),
@Partido int,
@Departamento varchar(20)
)
as begin
if exists(select PrimerNombre from Diputado where PrimerNombre=@PrimerNombre and PrimerApellido=@PrimerApellido)
	raiserror('El Diputado ya existe, Ingrese otro',16,1)
else 
	insert into Diputado( PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,EstadoVotacion,Partido,Departamento)
	values(@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@EstadoVotacion,@Partido,@Departamento)
end 

---------Actualizar-Diputado----
create procedure actualizarDiputado(
@idDiputado int,
@PrimerNombre varchar(25),
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@Estado varchar(25),
@partido int,
@Departamento varchar(2)
)
as 
begin
	update Diputado
	set PrimerNombre =@PrimerNombre, SegundoNombre = @segundoNombre, PrimerApellido = @PrimerApellido,SegundoApellido = @SegundoApellido, Estado = @Estado, Partido = @partido, Departamento = @Departamento 
where idDiputado =@idDiputado
end

---------Eliminar-Diputado----
create procedure eliminarDiputado(
@idDiputado int
)
as
begin
if exists(select estado,idDiputado from Diputado where idDiputado = @idDiputado and Estado='eliminado')
	raiserror ('El Diputado no existe en la base de datos',16,1)
else
	update Diputado
	set Estado = 'eliminado'
end
exec eliminarDiputado 1

---------consultar-Diputado----
create procedure consultarDiputado
as
begin
select idDiputado as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', p.NombrePartido as 'Partido Politico' from Diputado
inner join PartidoPolitico p on Partido= p.idPartido
end

-------	insertar votante-----
create procedure IngresarVotante(
@IdentidadVotante varchar(13),
@PrimerNombre varchar(25) ,
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25) ,
@edad int,
@sexo varchar(10),
@estadoVotante varchar(25),
@CodMunicipio varchar(2)
)
as begin
if exists(select PrimerNombre from votante where PrimerNombre=@PrimerNombre and PrimerApellido=@PrimerApellido)
	raiserror('El votante ya existe, Ingrese otro',16,1)
else 
	insert into votante(IdentidadVotante,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,edad,sexo,estadoVotante,codMunicipio)
values(@IdentidadVotante,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,@edad,@sexo,@estadoVotante,@CodMunicipio)
end

---------Actualizar-Votante----
create procedure actualizarVotante(
@IdentidadVotante varchar(13),
@PrimerNombre varchar(25) ,
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25) ,
@edad int,
@sexo varchar(10),
@estadoVotante varchar(25),
@CodMunicipio varchar(2)
)
as 
begin
	update votante
	set PrimerNombre =@PrimerNombre, SegundoNombre = @segundoNombre, PrimerApellido = @PrimerApellido,SegundoApellido = @SegundoApellido, Edad = @edad, sexo = @sexo, estadoVotante = @estadoVotante, CodMunicipio = @CodMunicipio 
where IdentidadVotante =@IdentidadVotante
end

---------Eliminar-Votante----
create procedure eliminarVotante(
@IdentidadVotante int
)
as
begin
if exists(select estadoVotante,IdentidadVotante from votante where IdentidadVotante = @IdentidadVotante and estadoVotante='eliminado')
	raiserror ('El Votante no existe en la base de datos',16,1)
else
	update votante
	set estadoVotante = 'eliminado'
end
exec eliminarVotante 1

---------consultar-Votante----
create procedure consultarVotante
as
begin
select IdentidadVotante as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', p.idMunicipio as 'Municipio' from votante
inner join Municipio p on CodMunicipio= idMunicipio
end
