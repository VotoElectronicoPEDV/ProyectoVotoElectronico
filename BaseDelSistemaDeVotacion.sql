create database SistemaNacionalDeElecciones
go

use SistemaNacionalDeElecciones
go

create table PartidoPolitico(
idPartido int identity primary key not null,
NombrePartido varchar(50) not null,
Lema varchar(100)
)

----------Insertar Partido Politico------------
insert into PartidoPolitico (NombrePartido,lema) values 
('Partido Nacional','Vamos hacer lo que tengamos que hacer'),
('Partido Libre','Por una Honduras mejor'),
('Partido AntiCorrupcion','Para Combatir la corrupcion'),
('Partido Liberal','Por un futuro mejor')
select *from PartidoPolitico

create table Presidente(
IdentidadPresidente varchar(13) primary key not null,
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
insert into Departamento(idDepartamento,nombreDepartamento) values
('03','Comayagua')
select *from Departamento

create table Municipio(
idMunicipio varchar(2) not null primary key,
nombreMunicipio varchar(50),
idDepartamento varchar(2) FOREIGN KEY REFERENCES Departamento(idDepartamento)
)
insert into Municipio(idMunicipio,nombreMunicipio,idDepartamento) values
('01','Comayagua','03'),
('02','Ajuterique','03'),
('03','El Rosario','03'),
('04','Esquías','03'),
('05','Humuya','03'),
('06','La Libertad','03'),
('07','Lamaní','03'),
('08','La Trinidad','03'),
('09','Lejamaní','03'),
('10','Meámbar','03'),
('11','Minas de Oro','03'),
('12','Ojos de Agua','03'),
('13','San Jerónimo','03'),
('14','San José de Comayagua','03'),
('15','San José del Potrero','03'),
('16','San Luis ','03'),
('17','San Sebastián','03'),
('18','Siguatepeque','03'),
('19','Villa de San Antonio','03'),
('20','Las Lajas','03'),
('21','Taulabé','03')
select *from Municipio;

create table Alcalde (
IdentidadAlcalde varchar(13) primary key not null,
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
IdentidadDiputado varchar(13) primary key not null,
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
estadoVotante varchar(10) not null
)
------------------------------------------------------------------Procedimientos-Almacenados---------------------------------------------------------------

-----------------------------------------------------------------------PRESIDENTE---------------------------------------------------------------

---------Insertar-Presidente----
create procedure ingresarPresidente(
@IdentidadPresidente varchar(13),
@PrimerNombre varchar(25),
@segundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@Estado varchar(25),
@idPartido int
)
as
begin
if exists(select IdentidadPresidente from Presidente where IdentidadPresidente=@IdentidadPresidente)
	raiserror('Esta persona ya desempeña el cargo de presidente',16,1)

else if exists(select IdentidadDiputado from Diputado where IdentidadDiputado=@IdentidadPresidente)
	raiserror('Esta persona ya desempeña un cargo de diputado',16,1)
	
else if exists(select IdentidadAlcalde from Alcalde where IdentidadAlcalde=@IdentidadPresidente)
	raiserror('Esta persona ya desempeña un cargo de alcalde',16,1)
else
	insert into Presidente(IdentidadPresidente,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,Estado,Partido)
	values(@IdentidadPresidente,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@Estado,@idPartido)
end
exec ingresarPresidente '0101197000188','Juan','Orlando','Hernandez','Alvarado','activo',1
exec ingresarPresidente '0101197000187','Luis','Orlando','Zelaya','Medrano ','activo',2 
exec ingresarPresidente '0101197000186','Jose','Manuel','Zelaya','Rosales','activo',3
exec ingresarPresidente '0101197000185','Salvador','Alejandro','Nasralla','Salum ','activo',4
select * from Presidente

---------Actualizar-Presidente----
create procedure actualizarPresidente(
@IdentidadPresidente varchar(13),
@PrimerNombre varchar(25),
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@partido int
)
as 
begin
if exists(select IdentidadPresidente, Estado from Presidente where IdentidadPresidente = @IdentidadPresidente and estado = 'activo')
update Presidente 
set PrimerNombre =@PrimerNombre, SegundoNombre = @segundoNombre, PrimerApellido = @PrimerApellido,SegundoApellido = @SegundoApellido, Partido = @partido
where IdentidadPresidente = @IdentidadPresidente
else
	raiserror('el Presidente no existe en la base de datos',16,1)
end
exec actualizarPresidente '0102197000188','Juan','Orlando','Hernandez','Alvarado',1

---------Eliminar-Presidente----
create procedure eliminarPresidente(@identidadPresidente varchar(13))
as
begin
if exists(select estado,IdentidadPresidente from Presidente where IdentidadPresidente = @IdentidadPresidente  and Estado='activo')
		update Presidente
	set Estado = 'eliminado'
	where IdentidadPresidente = @IdentidadPresidente
	
else
	raiserror ('el Presidente no existe en la base de datos',16,1)
end
exec eliminarPresidente '0101197000186'

---------consultar-Presidente----
create procedure consultarPresidente
as
begin
select IdentidadPresidente as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', p.NombrePartido as 'Partido Politico' from Presidente
inner join PartidoPolitico p on Partido= p.idPartido
end
exec consultarPresidente

-----------------------------------------------------------------------------------ALCALDE---------------------------------------------------------------------
	-------Insertar--Alcalde--
Create procedure ingresarAlcalde
(
@identidadAlcalde varchar(13),
@PrimerNombre varchar(25),
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@DescripcionVotacion varchar(25),
@Estado varchar(25),
@Partido int,
@Municipio varchar(2)
)
as
begin
if exists(select IdentidadPresidente from Presidente where IdentidadPresidente=@identidadAlcalde)
	raiserror('Esta persona ya desempeña el cargo de presidente',16,1)

else if exists(select IdentidadDiputado from Diputado where IdentidadDiputado=@identidadAlcalde)
	raiserror('Esta persona ya desempeña un cargo de diputado',16,1)
	
else if exists(select IdentidadAlcalde from Alcalde where IdentidadAlcalde=@identidadAlcalde)
	raiserror('Esta persona ya desempeña un cargo de alcalde',16,1)
else
	insert into Alcalde(IdentidadAlcalde,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,DescripcionVotacion,Estado,Partido,Municipio)
	values(@identidadAlcalde,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@DescripcionVotacion,@Estado,@Partido,@Municipio)
end
	
--------Municipio de Comayagua----------
--Partido Nacional
execute ingresarAlcalde '0301196000140','Carlos','Josue','Miranda', 'Canales','interna','activo',1,'01'
execute ingresarAlcalde '0301196000141','Trinidad', 'Jose ','cecilio', 'del Valle', 'interna', 'activo', 1, '01'
--Partido liberal
execute ingresarAlcalde '0301196000142','Juan', 'Carlos', 'Juarez', 'Gutierrez', 'interna', 'activo', 2, '01'
execute ingresarAlcalde '0301196000143','Pedro', 'Rafael ', 'Valladarez', 'Giron', 'interna', 'activo', 2,'01'
--Partido Anticorrupcion
execute ingresarAlcalde '0301196000144','Jose', 'Francisco', 'Hernandez', 'Canales', 'interna', 'activo', 3, '01'
execute ingresarAlcalde '0301196000145','Joseph', 'Josias ', 'Caceres', 'Rivas', 'interna', 'activo', 3, '01'
--Partido Libre
execute ingresarAlcalde '0301196000146','Edgar', 'Orlando', 'Gutierrez', 'Guzman', 'interna', 'activo', 4, '01'
execute ingresarAlcalde '0301196000147','Ever', 'Jose ', 'Morazan', 'Dominguez', 'interna', 'activo', 4, '01'

--------Municipio de Ajuterique----------
--Partido Nacional
execute ingresarAlcalde '0302196000140','Pedro', 'Alonso', 'Mosku', 'Canales', 'interna', 'activo', 1, '02'
execute ingresarAlcalde '0302196000141','Rey', 'Alonso ', 'Vasquez', 'Juarez', 'interna', 'activo', 1,'02'
--Partido liberal
execute ingresarAlcalde '0302196000142','Alberto', 'Jacob', 'Perez', 'Sambrano', 'interna', 'activo', 2,'02'
execute ingresarAlcalde '0302196000143','Feliciano', 'Roberto ', 'Pineda', 'Garcia', 'interna', 'activo', 2, '02'
--Partido Anticorrupcion
execute ingresarAlcalde '0302196000144','Ricardo', 'Alfonso', 'Guerra', 'Guerra', 'interna', 'activo', 3,'02'
execute ingresarAlcalde '0302196000145','Edgardo', 'Butin ', 'Prada', 'Rodriguez', 'interna', 'activo', 3, '02'
--Partido Libre
execute ingresarAlcalde '0302196000146','Kevin', 'Leonel', 'Lopez', 'Lopez', 'interna', 'activo', 4, '02'
execute ingresarAlcalde '0302196000147','Oscar', 'Rafael ', 'Llamazares', 'Caceres', 'interna', 'activo', 4,'02'

--------Municipio El Rosario----------
--Partido Nacional
execute ingresarAlcalde '0303196000140','Miguel', 'Fernando', 'Mosku', 'Canales', 'interna', 'activo', 1, '03'
execute ingresarAlcalde '0303196000141','Juan', 'Alonso ', 'Hernadez', 'Hernadez', 'interna', 'activo', 1, '03'
--Partido liberal
execute ingresarAlcalde '0303196000142','Alberto', 'Josias', 'Pacheco', 'Sambrano', 'interna', 'activo', 2, '03'
execute ingresarAlcalde '0303196000143','Celio', 'Roberto ', 'Pineda', 'Manzanares', 'interna', 'activo', 2, '03'
--Partido Anticorrupcion
execute ingresarAlcalde '0303196000144','Mercedes', 'Maria', 'Aranda', 'Gomez', 'interna', 'activo', 3, '03'
execute ingresarAlcalde '0303196000145','Mario', 'Arturo ', 'Espinoza', 'Cruz', 'interna', 'activo', 3, '03'
--Partido Libre
execute ingresarAlcalde '0303196000146','Francisco', 'Javier', 'Varela', 'Rosa', 'interna', 'activo', 4, '03'
execute ingresarAlcalde '0303196000147','Miguel', 'Angel ', 'Rodriguez', 'Funez', 'interna', 'activo', 4, '03'

--------Municipio Esquias----------
--Partido Nacional
execute ingresarAlcalde '0304196000140','Jose', 'Manuel', 'Sanchez', 'Campos', 'interna', 'activo', 1, '04'
execute ingresarAlcalde '0304196000141','Carlos', 'Hernan ', 'Vanegas', 'Bueso', 'interna', 'activo', 1, '04'
--Partido liberal
execute ingresarAlcalde '0304196000142','Carlos', 'Daniel', 'Cerrano', 'Ortiz', 'interna', 'activo', 2, '04'
execute ingresarAlcalde '0304196000143','Celio', 'Roberto ', 'Pineda', 'Manzanares', 'interna', 'activo', 2, '04'
--Partido Anticorrupcion
execute ingresarAlcalde '0304196000144','Mariano', 'Enrrique', 'Garcia', 'Lopez', 'interna', 'activo', 3, '04'
execute ingresarAlcalde '0304196000145','Raul', 'Fernando ', 'Peralda', 'Mendoza', 'interna', 'activo', 3,'04'
--Partido Libre
execute ingresarAlcalde '0304196000146','Alejandro', 'Rafael', 'Quintana', 'Diaz', 'interna', 'activo', 4, '04'
execute ingresarAlcalde '0304196000147','Daniel', 'Emilio ', 'De la Peña', 'Campos', 'interna', 'activo', 4, '04'

--------Municipio Humuya----------
--Partido Nacional
execute ingresarAlcalde '0305196000140','Sergio', 'Antonio', 'Ortiz', 'Osorio', 'interna', 'activo', 1, '05'
execute ingresarAlcalde '0305196000141','Eduardo', 'Antonio ', 'Meza', 'Saravia', 'interna', 'activo', 1, '05'
--Partido liberal
execute ingresarAlcalde '0301596000142','Juan', 'Gabriel', 'Ramos', 'Martinez', 'interna', 'activo', 2, '05'
execute ingresarAlcalde '0305196000143','Gabriela', 'Aurora', 'Molina', 'Horosco', 'interna', 'activo', 2, '05'
--Partido Anticorrupcion
execute ingresarAlcalde '0305196000144','Felix', 'Eduardo', 'Mencia', 'Perez', 'interna', 'activo', 3, '05'
execute ingresarAlcalde '0305196000145','Feliciano', 'Ramon', 'Romero', 'Juarez', 'interna', 'activo', 3, '05'
--Partido Libre
execute ingresarAlcalde '0305196000146','Pedro', 'ALfonso', 'Ramos', 'Montoya', 'interna', 'activo', 4, '05'
execute ingresarAlcalde '0305196000147','Cristian', 'Jose', 'Jimenez', 'Peralda', 'interna', 'activo', 4, '05'
select *from Alcalde

	-------Procedimientos Almacenados-----
	---------Actualizar-Alcalde----
create procedure actualizarAlcalde(
@identidadAlcalde varchar(13),
@PrimerNombre varchar(25),
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@Partido int
)
as 
begin
if exists(select identidadAlcalde, Estado from Alcalde where IdentidadAlcalde = @identidadAlcalde and estado = 'activo')
update Alcalde 
set PrimerNombre =@PrimerNombre, SegundoNombre = @segundoNombre, PrimerApellido = @PrimerApellido,SegundoApellido = @SegundoApellido, Partido = @partido
where identidadAlcalde = @identidadAlcalde
else
	raiserror('el alcande no existe en la base de datos',16,1)
end
exec actualizarAlcalde '0305196000147','Cristian', 'Joel', 'Jimenez', 'Peralda',4

---------Eliminar-Alcalde----
create procedure eliminarAlcalde(@identidadAlcalde varchar(13))
as
begin
if exists(select estado,IdentidadAlcalde from Alcalde where IdentidadAlcalde = @identidadAlcalde  and Estado ='activo')
		update Alcalde
	set Estado = 'eliminado'
	where IdentidadAlcalde = @identidadAlcalde
	
else
	raiserror ('el Alcalde no existe en la base de datos',16,1)
end
exec eliminarAlcalde '0305196000147'



---------consultar-Alcalde----
create procedure consultarAlcalde
as
begin
select IdentidadAlcalde as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo',M.nombreMunicipio as Municipio, D.nombreDepartamento as Departamento , p.NombrePartido as 'Partido Politico' from Alcalde
inner join PartidoPolitico p on Partido= p.idPartido
inner join Municipio M on Municipio = M.idMunicipio
inner join Departamento D on M.idDepartamento = D.idDepartamento
end
exec consultarAlcalde

----------------------------------------------------------------------Diputados-----------------------------------------------------------------------------------
	----------insertar Diputado--------

create procedure ingresarDiputado(
@identidadDiputado varchar(13),
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
if exists(select IdentidadPresidente from Presidente where IdentidadPresidente = @identidadDiputado)
	raiserror('Esta persona ya desempeña el cargo de presidente',16,1)

else if exists(select IdentidadDiputado from Diputado where IdentidadDiputado = @identidadDiputado)
	raiserror('Esta persona ya desempeña un cargo de diputado',16,1)
	
else if exists(select IdentidadAlcalde from Alcalde where IdentidadAlcalde = @identidadDiputado)
	raiserror('Esta persona ya desempeña un cargo de alcalde',16,1)
else

	insert into Diputado(IdentidadDiputado,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,Estado,Partido,Departamento)
	values(@identidadDiputado,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@Estado,@Partido,@Departamento)
end 

			-------------Partido Nacional----
exec ingresarDiputado '0301197000130','Oscar','Aturo','Alvarez','Guerrero','activo',1,'03' 
exec ingresarDiputado '0302197000131','HECTOR ','GUILLERMO',' GUILLEN ','GOMEZ','activo',1,'03'
exec ingresarDiputado '0303197000132','JOSE',' MARIA ','MARTINEZ ','VALENZUELA','activo',1,'03'
exec ingresarDiputado '0304197000133','JOSE ','VICENTE',' LEON ','ROJAS','activo',1,'03'
exec ingresarDiputado '0305197000134','REINALDO ','ANTONIO ','SANCHEZ',' RIVERA','activo',1,'03'
exec ingresarDiputado '0306197000135','JOSE ','CELIN',' DISCUA ','ELVIR','activo',1,'03'
exec ingresarDiputado '0307197000136','JOSE ','TOMAS ','PONCE ','POSAS','activo',1,'03 '

-------------Partido Libre----
exec ingresarDiputado '0308197000137','RAMON ','ANTONIO ','LEVA ','BULNES','activo',2,'03'
exec ingresarDiputado '0309197000138','JUAN','CARLOS',' VALENZUELA ','MOLINA','activo',2,'03'
exec ingresarDiputado '0310197000139','MIDENCE ','OQUELY',' MARTINEZ ','TURCIOS','activo',2,'03'
exec ingresarDiputado '0311197000140','ANA',' JULIA ','GARCIA ','VILLALOBOS','activo',2,'03'
exec ingresarDiputado '0312197000141','FELIPE ','ZUNIGA ','DEL ','CID','activo',2,'03'
exec ingresarDiputado '0313197000142','GLADIS',' AURORA ','LOPEZ',' CALDERON','activo',2,'03' 
exec ingresarDiputado '0314197000143','LUIS ','RIGOBERTO ','SANTOS ','PORTILLO','activo',2,'03'

-------------Partido anticorrupcion----

exec ingresarDiputado '0315197000144','JOSUE ','WILMER ','RIVAS ','MORENO','activo',3,'03'
exec ingresarDiputado '0316197000145','MARIO','JOS',' GAMALIEL','RIVERA ','activo',3,'03'
exec ingresarDiputado '0317197000146','CELENA ','SOFIA ','LEVY ','LEVY','activo',3,'03'
exec ingresarDiputado '0318197000147','RAUL','JOSUE',' MENDEZ ','CASTRO','activo',3,'03'
exec ingresarDiputado '0317197000148','PEDRO ','ANTONIA',' MEZA ','PONCE','activo',3,'03'
exec ingresarDiputado '0316197000149','KEREN',' MARIA ','ARANDA ','QUINTANA','activo',3,'03'
exec ingresarDiputado '0315197000150','MARIO ','ANTONIO ','GUERRA ','DEL CID','activo',3,'03'

-------------Partido ALiberal----
exec ingresarDiputado '0314197000151','ANA ','MARIA ','PEREZ ','LOPEZ','activo',4,'03'
exec ingresarDiputado '0313197000152','GERARDO','ANTONIO',' VILLANUEVA ','CORTES','activo',4,'03'
exec ingresarDiputado '0312197000153','JUAN ','CARLOS',' VILLALOBOS ','ANDINO','activo',4,'03'
exec ingresarDiputado '0311197000154','LETICA',' MACARENA ','RAMOS ','CACERES','activo',4,'03'
exec ingresarDiputado '0310197000155','GENESIS ','NAHOMI ','CASTRO ','MORENO','activo',4,'03'
exec ingresarDiputado '0309197000156','RAMON',' ENRIQUE ','MARTINEZ',' MARTINEZ','activo',4,'03' 
exec ingresarDiputado '0308197000157','JAIRO ','PATRICIO ','GOMEZ ','CORTEZ','activo',4,'03'

select * from Diputado

---------Actualizar-Diputado----
create procedure actualizarDiputado(
@identidadDiputado varchar(13),
@PrimerNombre varchar(25),
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@partido int
)
as 
begin
if exists(select IdentidadDiputado, Estado from Diputado where IdentidadDiputado = @identidadDiputado and estado = 'activo')
	update Diputado 
	set PrimerNombre = @PrimerNombre, SegundoNombre = @segundoNombre, PrimerApellido = @PrimerApellido,SegundoApellido = @SegundoApellido, Partido = @partido
	where IdentidadDiputado = @identidadDiputado
else
	raiserror('el Diputado no existe en la base de datos',16,1)
end
exec actualizarDiputado '0308197000157','JAIRO ','PATRICIO ','GOMEZ ','CORTEZ',4

---------Eliminar-Diputado----

create procedure eliminarDiputado(@identidadDiputado varchar(13))
as
begin
if exists(select estado,identidadDiputado from Diputado where identidadDiputado = @identidadDiputado  and Estado ='activo')
		update Diputado
	set Estado = 'eliminado'
	where identidadDiputado = @identidadDiputado
	
else
	raiserror ('el Diputado no existe en la base de datos',16,1)
end
exec eliminarDiputado '0308197000157'

	---------consultar-Diputado----
create procedure consultarDiputado
as
begin
select IdentidadDiputado as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', D.nombreDepartamento as Departamento, p.NombrePartido as 'Partido Politico' from Diputado
inner join PartidoPolitico p on Partido= p.idPartido
inner join Departamento D on Departamento = D.idDepartamento
end
exec consultarDiputado
----------------------------------------------------------------------VOTANTE-----------------------------------------------------------------------------------
	-------	insertar votante-----
create procedure IngresarVotante(
@IdentidadVotante varchar(13),
@PrimerNombre varchar(25) ,
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25) ,
@edad int,
@sexo varchar(10),
@estadoVotante varchar(25)
)
as begin
if exists(select IdentidadVotante from votante where IdentidadVotante = @IdentidadVotante)
	raiserror('El votante ya existe, Ingrese otro',16,1)
else 
	insert into votante(IdentidadVotante,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,edad,sexo,estadoVotante)
values(@IdentidadVotante,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,@edad,@sexo,@estadoVotante)
end
execute IngresarVotante '0319200301323', 'Karla', 'Gissel', 'Lopez', 'Caceres',21,'Femenino','Activo'
select * from votante

	---------Actualizar-Votante----
create procedure actualizarVotante(
@IdentidadVotante varchar(13),
@PrimerNombre varchar(25) ,
@SegundoNombre varchar(25),
@PrimerApellido varchar(25),
@SegundoApellido varchar(25),
@edad int,
@sexo varchar(10)
)
as 
begin
if exists(select IdentidadVotante, estadoVotante from votante where IdentidadVotante = @IdentidadVotante and estadoVotante = 'activo')
	update votante 
	set PrimerNombre =@PrimerNombre, SegundoNombre = @segundoNombre, PrimerApellido = @PrimerApellido,SegundoApellido = @SegundoApellido, Edad = @edad, sexo = @sexo
    where IdentidadVotante =@IdentidadVotante
else
	raiserror('el votante no existe en la base de datos',16,1)
end
exec actualizarVotante '0318200301323', 'Karla', 'Gissel', 'Lopez', 'Caceres',21,'Femenino'

	---------EliminarVotante----
create procedure eliminarVotante(
@IdentidadVotante varchar(13)
)
as
begin
if exists(select estadoVotante,IdentidadVotante from votante where IdentidadVotante = @IdentidadVotante and estadoVotante='activo')
	update votante
	set estadoVotante = 'eliminado'
else
 raiserror ('El Votante no existe en la base de datos',16,1)
end
exec eliminarVotante '0318200301323'

---------consultar-Votante----
create procedure consultarVotante
as
begin
select IdentidadVotante as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', estadoVotante as 'Estado' from votante
end
exec consultarVotante

	------Procedimiento almacenado-----
	------Buscar por identidad--------
Create procedure validarVotante(@IdentidadVotante varchar(13))
as
begin
select estadoVotante from votante where IdentidadVotante = @IdentidadVotante
end
execute validarVotante '0319200301323'


-------------------------------------validar usuario-------------------------------------
------------------------------------Procedimiento almacenado validar usuario-------------
 create procedure validarUusario(
 @usuername varchar (25),
 @pws varchar (40)
 )


 as begin
 if exists (select estado from usuario where NombreUsuario = @usuername and Pws = @pws and estado = 'activo')
 select * from usuario
 else
 raiserror('No encontrado',16,1)
 end


