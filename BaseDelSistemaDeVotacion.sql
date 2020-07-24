Create database SistemaNacionalDeElecciones
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
VotosValidos int not null default 0,
VotosNulos int default 0,
Estado varchar(25) not null,
Foto image,
Voto varchar(1) not null,
Partido int FOREIGN KEY REFERENCES PartidoPolitico(idPartido)
)
select * from presidente

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

create table Alcalde(
IdentidadAlcalde varchar(13) primary key not null,
PrimerNombre varchar(25) not null,
SegundoNombre varchar(25),
PrimerApellido varchar(25) not null,
SegundoApellido varchar(25),
VotosValidos int not null default 0,
VotosNulos int not null default 0,
DescripcionVotacion varchar(25) not null,
Estado varchar(25) not null,
Foto image,
Voto varchar(1) not null,
Partido int FOREIGN KEY REFERENCES PartidoPolitico(idPartido),
Municipio varchar(2) FOREIGN KEY REFERENCES Municipio(idMunicipio)
)

create table Diputado(
IdentidadDiputado varchar(13) primary key not null,
PrimerNombre varchar(25) not null,
SegundoNombre varchar(25),
PrimerApellido varchar(25) not null,
SegundoApellido varchar(25),
VotosValidos int not null default 0,
VotosNulos int not null default 0,
Estado varchar(25) not null,
Foto image,
Voto varchar(1) not null,
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
foto image,
voto varchar(1) not null,
estadoVotante varchar(10) not null
)
create table administrador(
identidad varchar(13) not null,
contraseña varchar(15) not null,
estado varchar(25) not null,
voto varchar(1) not null,
foto image
)
select *from administrador
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
	insert into Presidente(IdentidadPresidente,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Estado,Voto,Partido)
	values(@IdentidadPresidente,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,@Estado,'F',@idPartido)
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
Create procedure consultarPresidente
as
begin
select IdentidadPresidente as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo',VotosValidos,VotosNulos,voto,foto,p.NombrePartido as 'Partido Politico' from Presidente 
inner join PartidoPolitico p on Partido= p.idPartido
where estado='activo'
end
exec consultarPresidente
select *from Presidente

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
	insert into Alcalde(IdentidadAlcalde,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,DescripcionVotacion,Estado,Voto,Partido,Municipio)
	values(@identidadAlcalde,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,@DescripcionVotacion,@Estado,'F',@Partido,@Municipio)
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

--------Municipio La Libertad----------
--Partido Nacional
execute ingresarAlcalde '0306196005140','Daniel', 'Eduarto', 'Ortiz', 'Duarte', 'interna', 'activo', 1, '06'
execute ingresarAlcalde '0306196250141','Felix', 'Gabriel ', 'Ramos', 'Sambrano', 'interna', 'activo', 1, '06'
--Partido liberal
execute ingresarAlcalde '0306596000842','Pedro', 'Josue', 'Perez', 'Lopez', 'interna', 'activo', 2, '06'
execute ingresarAlcalde '0306196001243','Daniela', 'Felicia', 'Valladarez', 'Garcia', 'interna', 'activo', 2, '06'
--Partido Anticorrupcion
execute ingresarAlcalde '0306196000544','Juan', 'Jose', 'Caceres', 'Perez', 'interna', 'activo', 3, '06'
execute ingresarAlcalde '0306194600145','Isais', 'Otoniel', 'Lopez', 'Lopez', 'interna', 'activo', 3, '06'
--Partido Libre
execute ingresarAlcalde '0306196000148','Kesler', 'Alberto', 'Mencias', 'Guerra', 'interna', 'activo', 4, '06'
execute ingresarAlcalde '0306196000187','Oscar', 'Daniel', 'Gutierrez', 'Vazques', 'interna', 'activo', 4, '06'

--------Municipio Lamani----------
--Partido Nacional
execute ingresarAlcalde '0307196008147','Mario', 'Otoniel', 'Perez', 'Padilla', 'interna', 'activo', 1, '07'
execute ingresarAlcalde '0307196270148','Jimin', 'Josue ', 'Park', 'Lopez', 'interna', 'activo', 1, '07'
--Partido liberal
execute ingresarAlcalde '0307596000855','Jin', 'Eduardo', 'Manzaares', 'Caceres', 'interna', 'activo', 2, '07'
execute ingresarAlcalde '0307196001563','Josue', 'Rafael', 'Mencias', 'Guerra', 'interna', 'activo', 2, '07'
--Partido Anticorrupcion
execute ingresarAlcalde '0307196007744','Keyla', 'Leticia', 'Muños', 'Jimenez', 'interna', 'activo', 3, '07'
execute ingresarAlcalde '0307194602245','Daniel', 'Patricio', 'Hernandez', 'Juarez', 'interna', 'activo', 3, '07'
--Partido Libre
execute ingresarAlcalde '0307176000158','Kendy', 'Patricia', 'Gutierrez', 'Gutierrez', 'interna', 'activo', 4, '07'
execute ingresarAlcalde '0307189000187','Ignacion', 'Jasiel', 'Perez', 'Perez', 'interna', 'activo', 4, '07'

--------Municipio La Trinidad----------
--Partido Nacional
execute ingresarAlcalde '0308196048143','Josue', 'Benjamin', 'Menendez', 'Perez', 'interna', 'activo', 1, '08'
execute ingresarAlcalde '0308196270148','Hector', 'Daniel ', 'Jimenez', 'Caceres', 'interna', 'activo', 1, '08'
--Partido liberal
execute ingresarAlcalde '0308596004865','Jackson', 'Eduardo', 'Garcia', 'Garcia', 'interna', 'activo', 2, '08'
execute ingresarAlcalde '0308196013563','Victor', 'Rafael', 'Peralta', 'Trinidad', 'interna', 'activo', 2, '08'
--Partido Anticorrupcion
execute ingresarAlcalde '0308196055744','Oscar', 'Josep', 'Hernandez', 'Perez', 'interna', 'activo', 3, '08'
execute ingresarAlcalde '0308194602785','Linda', 'Daniela', 'Jimenes', 'Lopez', 'interna', 'activo', 3, '08'
--Partido Libre
execute ingresarAlcalde '0308156000159','Julio', 'Pedro', 'Mazanares', 'Caceres', 'interna', 'activo', 4, '08'
execute ingresarAlcalde '0308189000288','Delia', 'Maria', 'Torres', 'Lopez', 'interna', 'activo', 4, '08'

--------Municipio Lejamani----------
--Partido Nacional
execute ingresarAlcalde '0309196048153','Linda', 'Jaiela', 'Perez', 'Perez', 'interna', 'activo', 1, '09'
execute ingresarAlcalde '0309196270256','Josep', 'Eduardo ', 'Caceres', 'Jimenez', 'interna', 'activo', 1, '09'
--Partido liberal
execute ingresarAlcalde '0309596004865','Angelica', 'Yareli', 'Ramos', 'Lopez', 'interna', 'activo', 2, '09'
execute ingresarAlcalde '0309196013563','Josue', 'Trinidad', 'Jill', 'Peralda', 'interna', 'activo', 2, '09'
--Partido Anticorrupcion
execute ingresarAlcalde '0309196054544','Stefany', 'Daniela', 'Manzanares', 'Ordonez', 'interna', 'activo', 3, '09'
execute ingresarAlcalde '0309194605585','Eliud', 'Daniel', 'Garcia', 'Lopez', 'interna', 'activo', 3, '09'
--Partido Libre
execute ingresarAlcalde '0309156081159','Ana', 'Yencia', 'Cabañas', 'Valladares', 'interna', 'activo', 4, '09'
execute ingresarAlcalde '0309189880288','Gian', 'Carlos', 'Torres', 'Padilla', 'interna', 'activo', 4, '09'

--------Municipio Meambar----------
--Partido Nacional
execute ingresarAlcalde '0310604815388','Gabriela', 'Lisbet', 'Perez', 'Perez', 'interna', 'activo', 1, '10'
execute ingresarAlcalde '0310196270256','Oscar', 'Vilnad ', 'Gutierrez', 'Jimenez', 'interna', 'activo', 1, '10'
--Partido liberal
execute ingresarAlcalde '0310596004865','Jesica', 'Nayeli', 'Barjas', 'Lopez', 'interna', 'activo', 2, '10'
execute ingresarAlcalde '0310196013563','Victor', 'David', 'Park', 'Peralda', 'interna', 'activo', 2, '10'
--Partido Anticorrupcion
execute ingresarAlcalde '0310196054544','Leonel', 'Fernando', 'Valladarez', 'Perez', 'interna', 'activo', 3, '10'
execute ingresarAlcalde '0310194605585','Cristian', 'Josue', 'Jimenez', 'Lopez', 'interna', 'activo', 3, '10'
--Partido Libre
execute ingresarAlcalde '0310156081159','Delia', 'Patricia', 'Jimenez', 'Jimenez', 'interna', 'activo', 4, '10'
execute ingresarAlcalde '0310189880288','Sheldon', 'David', 'Park', 'Sevilla', 'interna', 'activo', 4, '10'

--------Municipio Minas de Oro----------
--Partido Nacional
execute ingresarAlcalde '0311604817588','Julissa', 'Daneli', 'Castillo', 'Chavarria', 'interna', 'activo', 1, '11'
execute ingresarAlcalde '0311196278256','Andres', 'Josue ', 'Castillo', 'Espinal', 'interna', 'activo', 1, '11'
--Partido liberal
execute ingresarAlcalde '0311596004865','Killa', 'Nayeli', 'Rojas', 'Guerra', 'interna', 'activo', 2, '11'
execute ingresarAlcalde '0311196013763','Josue', 'Fernando', 'Hernandez', 'Muñoz', 'interna', 'activo', 2, '11'
--Partido Anticorrupcion
execute ingresarAlcalde '0311196054554','Jissel', 'Gabriel', 'Perez', 'Peralta', 'interna', 'activo', 3, '11'
execute ingresarAlcalde '0311194605575','Daniel', 'Fernando', 'Marquez', 'Lopez', 'interna', 'activo', 3, '11'
--Partido Libre
execute ingresarAlcalde '0311156081153','Nazareth', 'Dayana', 'Ramos', 'Perez', 'interna', 'activo', 4, '11'
execute ingresarAlcalde '0311189880280','Katerin', 'Nicoll', 'Bardales', 'Lopez', 'interna', 'activo', 4, '11'

--------Municipio Ojos de Agua----------
--Partido Nacional
execute ingresarAlcalde '0312604867587','Perla', 'Osiris', 'Juarez', 'Perez', 'interna', 'activo', 1, '12'
execute ingresarAlcalde '0312196274556','Daniel', 'Alberto ', 'Espinal', 'jimenez', 'interna', 'activo', 1, '12'
--Partido liberal
execute ingresarAlcalde '0312596003865','Darwin', 'Daniel', 'Betancur', 'Garcia', 'interna', 'activo', 2, '12'
execute ingresarAlcalde '0312196013783','Josue', 'Fernando', 'Kell', 'Hernandez', 'interna', 'activo', 2, '12'
--Partido Anticorrupcion
execute ingresarAlcalde '0312196054454','Carlos', 'Gilberto', 'Molina', 'Castillo', 'interna', 'activo', 3, '12'
execute ingresarAlcalde '0312194645575','Gabriel', 'Fernando', 'Marquez', 'Lopez', 'interna', 'activo', 3, '12'
--Partido Libre
execute ingresarAlcalde '0312156081173','Cartlon', 'David', 'Perez', 'Perez', 'interna', 'activo', 4, '12'
execute ingresarAlcalde '0312189880281','Dayana', 'Nicoll', 'Bardales', 'Lopez', 'interna', 'activo', 4, '12'

--------Municipio San Jeronimo----------
--Partido Nacional
execute ingresarAlcalde '0313604867583','Nicol', 'Darin', 'Manzanares', 'Castillo', 'interna', 'activo', 1, '13'
execute ingresarAlcalde '0313196274557','Josue', 'Efrain ', 'Garcia', 'Lopez', 'interna', 'activo', 1, '13'
--Partido liberal
execute ingresarAlcalde '0313596003965','Tesla', 'Daniela', 'Perez', 'Marquez', 'interna', 'activo', 2, '13'
execute ingresarAlcalde '0313196017783','Dariel', 'Alberto', 'Pa', 'Mendoza', 'interna', 'activo', 2, '13'
--Partido Anticorrupcion
execute ingresarAlcalde '0313196054454','Samuel', 'Isac', 'Guerra', 'Castillo', 'interna', 'activo', 3, '13'
execute ingresarAlcalde '031319464775','Daniel', 'Jeferson', 'Marquez', 'Paz', 'interna', 'activo', 3, '13'
--Partido Libre
execute ingresarAlcalde '0313156081173','Denisse', 'Andrea', 'Montoya', 'Perez', 'interna', 'activo', 4, '13'
execute ingresarAlcalde '0313189880781','Denis', 'Abrhan', 'Caceres', 'Lopez', 'interna', 'activo', 4, '13'

--------Municipio San Jose de Comayagua----------
--Partido Nacional
execute ingresarAlcalde '0314604867583','Andrea', 'Melissa', 'Caceres', 'Jimenez', 'interna', 'activo', 1, '14'
execute ingresarAlcalde '0314196274557','Deris', 'Julissa ', 'Lopez', 'Lopez', 'interna', 'activo', 1, '14'
--Partido liberal
execute ingresarAlcalde '0314596003965','Darwin', 'Daniel', 'Betancur', 'Marquez', 'interna', 'activo', 2, '14'
execute ingresarAlcalde '0314196017783','Jonatan', 'Fabiel', 'Perez', 'Mendoza', 'interna', 'activo', 2, '14'
--Partido Anticorrupcion
execute ingresarAlcalde '0314196054454','Daniel', 'Josue', 'Claros', 'Paz', 'interna', 'activo', 3, '14'
execute ingresarAlcalde '031419464775','Efrain', 'Alberto', 'Castillo', 'Garcia', 'interna', 'activo', 3, '14'
--Partido Libre
execute ingresarAlcalde '0314156081173','Misael', 'Alfredo', 'Juarez', 'Perez', 'interna', 'activo', 4, '14'
execute ingresarAlcalde '0314189880781','Mario', 'Denis', 'Gutierrez', 'Lopez', 'interna', 'activo', 4, '14'

--------Municipio San Jose del Potrero----------
--Partido Nacional
execute ingresarAlcalde '0315604867583','Deris', 'Daneli', 'Espinal', 'Perez', 'interna', 'activo', 1, '15'
execute ingresarAlcalde '0315196564557','Angelica', 'Nasaret ', 'Carranza', 'Marquez', 'interna', 'activo', 1, '15'
--Partido liberal
execute ingresarAlcalde '0315196004465','Josue', 'Isac', 'Perez', 'Sambrano', 'interna', 'activo', 2, '15'
execute ingresarAlcalde '0315196017783','Ken', 'Fabricio', 'Perez', 'Mendoza', 'interna', 'activo', 2, '15'
--Partido Anticorrupcion
execute ingresarAlcalde '0315196054454','Andres', 'Josue', 'Rojas', 'Paz', 'interna', 'activo', 3, '15'
execute ingresarAlcalde '0315196665735','Sarvia', 'Lisbet', 'Jimenez', 'Garcia', 'interna', 'activo', 3, '15'
--Partido Libre
execute ingresarAlcalde '0315196081173','Walter', 'Alfredo', 'Duarte', 'Perez', 'interna', 'activo', 4, '15'
execute ingresarAlcalde '0315189885581','Jonas', 'Alberto', 'Gutierrez', 'Duarte', 'interna', 'activo', 4, '15'

--------Municipio San Luis----------
--Partido Nacional
execute ingresarAlcalde '0316194867583','Josep', 'Daniel', 'Caceres', 'perez', 'interna', 'activo', 1, '16'
execute ingresarAlcalde '0316196274557','Carlos', 'Jose ', 'Lopez', 'Caceres', 'interna', 'activo', 1, '16'
--Partido liberal
execute ingresarAlcalde '03161980003965','Darwin', 'Dario', 'Castillo', 'Marquez', 'interna', 'activo', 2, '16'
execute ingresarAlcalde '0316196017783','Pedro', 'Fabiel', 'Perez', 'Jimenez', 'interna', 'activo', 2, '16'
--Partido Anticorrupcion
execute ingresarAlcalde '0316196554454','Daniel', 'Fraid', 'Duarte', 'Paz', 'interna', 'activo', 3, '16'
execute ingresarAlcalde '0316194647751','Walter', 'Efraini', 'Castillo', 'Garcia', 'interna', 'activo', 3, '16'
--Partido Libre
execute ingresarAlcalde '0316196081173','Andres', 'Dario', 'Duarte', 'Perez', 'interna', 'activo', 4, '16'
execute ingresarAlcalde '0316199880781','Andrea', 'Denis', 'Gutierrez', 'Manzanares', 'interna', 'activo', 4, '16'

--------Municipio San Sebastia----------
--Partido Nacional
execute ingresarAlcalde '0317194867583','Pedro', 'Jose', 'Lopez', 'Jimenez', 'interna', 'activo', 1, '17'
execute ingresarAlcalde '0317196274557','Karla', 'Danessa ', 'Garcia', 'Lopez', 'interna', 'activo', 1, '17'
--Partido liberal
execute ingresarAlcalde '0317196003965','Karen', 'Daniela', 'Zaravia', 'Marquez', 'interna', 'activo', 2, '17'
execute ingresarAlcalde '0317196017783','Any', 'Michell', 'Duarte', 'Mendoza', 'interna', 'activo', 2, '17'
--Partido Anticorrupcion
execute ingresarAlcalde '0317196054454','Allan', 'David', 'Perez', 'Paz', 'interna', 'activo', 3, '17'
execute ingresarAlcalde '031719464775','Olban', 'Jose', 'Castillo', 'Manzanarez', 'interna', 'activo', 3, '17'
--Partido Libre
execute ingresarAlcalde '0317196081173','Walter', 'Daniel', 'Guerra', 'Perez', 'interna', 'activo', 4, '17'
execute ingresarAlcalde '0317199880781','Dariel', 'Alberto', 'Gutierrez', 'Caceres', 'interna', 'activo', 4, '17'

--------Municipio Siguatepeque----------
--Partido Nacional
execute ingresarAlcalde '0318197867583','Mimua', 'Danely', 'Jimenez', 'Jimenez', 'interna', 'activo', 1, '18'
execute ingresarAlcalde '0318196274557','Nayeli', 'Lisbet ', 'Cacere', 'Lopez', 'interna', 'activo', 1, '18'
--Partido liberal
execute ingresarAlcalde '0318196003965','Darwin', 'Daniel', 'Betancur', 'Marquez', 'interna', 'activo', 2, '18'
execute ingresarAlcalde '0318196017783','Jonatan', 'Fabiel', 'Perez', 'Mendoza', 'interna', 'activo', 2, '18'
--Partido Anticorrupcion
execute ingresarAlcalde '0318196054454','Daniel', 'Josue', 'Claros', 'Paz', 'interna', 'activo', 3, '18'
execute ingresarAlcalde '031819464775','Efrain', 'Alberto', 'Castillo', 'Garcia', 'interna', 'activo', 3, '18'
--Partido Libre
execute ingresarAlcalde '0318196081173','Misael', 'Alfredo', 'Juarez', 'Perez', 'interna', 'activo', 4, '18'
execute ingresarAlcalde '0318199880781','Mario', 'Denis', 'Gutierrez', 'Lopez', 'interna', 'activo', 4, '18'

--------Municipio Villa de San Antonio----------
--Partido Nacional
execute ingresarAlcalde '0319194867583','Denis', 'Ariel', 'Perez', 'Jimenez', 'interna', 'activo', 1, '19'
execute ingresarAlcalde '0319196274557','Oscar', 'Alonso ', 'Gutierrez', 'Lopez', 'interna', 'activo', 1, '19'
--Partido liberal
execute ingresarAlcalde '0319196003965','Misael', 'Alberto', 'Manzanarez', 'Marquez', 'interna', 'activo', 2, '19'
execute ingresarAlcalde '0319196017783','Jitian', 'Fabiel', 'Juarez', 'Mendoza', 'interna', 'activo', 2, '19'
--Partido Anticorrupcion
execute ingresarAlcalde '0319196054454','Dariel', 'Alfredo', 'Rojas', 'Paz', 'interna', 'activo', 3, '19'
execute ingresarAlcalde '031919464775','Alberto', 'Daniel', 'Mencia', 'Garcia', 'interna', 'activo', 3, '19'
--Partido Libre
execute ingresarAlcalde '0319196081173','Pedro', 'Denis', 'Mendoza', 'Perez', 'interna', 'activo', 4, '19'
execute ingresarAlcalde '0319199880781','Juan', 'Pablo', 'Caceres', 'Lopez', 'interna', 'activo', 4, '19'



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
select IdentidadAlcalde as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo',VotosValidos,VotosNulos,voto,foto,M.nombreMunicipio as Municipio, D.nombreDepartamento as Departamento , p.NombrePartido as 'Partido Politico' from Alcalde
inner join PartidoPolitico p on Partido= p.idPartido
inner join Municipio M on Municipio = M.idMunicipio
inner join Departamento D on M.idDepartamento = D.idDepartamento
where estado='activo'
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

	insert into Diputado(IdentidadDiputado,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Estado,Voto,Partido,Departamento)
	values(@identidadDiputado,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,@Estado,'F',@Partido,@Departamento)
end 
		-------------Partido Nacional----
exec ingresarDiputado '0301197000130','Oscar','Aturo','Alvarez','Guerrero','activo',1,'03' 
exec ingresarDiputado '0302197000131','HECTOR ','GUILLERMO',' GUILLEN ','GOMEZ','activo',1,'03'
exec ingresarDiputado '0303197000132','JOSE',' MARIA ','MARTINEZ ','VALENZUELA','activo',1,'03'
exec ingresarDiputado '0304197000133','JOSE ','VICENTE',' LEON ','ROJAS','activo',1,'03'
exec ingresarDiputado '0305197000134','REINALDO ','ANTONIO ','SANCHEZ',' RIVERA','activo',1,'03'
exec ingresarDiputado '0306197000135','JOSE ','CELIN',' DISCUA ','ELVIR','activo',1,'03'
exec ingresarDiputado '0307197000136','JOSE ','TOMAS ','PONCE ','POSAS','activo',1,'03 '
exec ingresarDiputado '0308197000137','RAMON ','ANTONIO ','LEVA ','BULNES','activo',1,'03'
exec ingresarDiputado '0309197000138','JUAN','CARLOS',' VALENZUELA ','MOLINA','activo',1,'03'

-------------Partido Libre----
exec ingresarDiputado '0310197000139','MIDENCE ','OQUELY',' MARTINEZ ','TURCIOS','activo',2,'03'
exec ingresarDiputado '0311197000140','ANA',' JULIA ','GARCIA ','VILLALOBOS','activo',2,'03'
exec ingresarDiputado '0312197000141','FELIPE ','ZUNIGA ','DEL ','CID','activo',2,'03'
exec ingresarDiputado '0313197000142','GLADIS',' AURORA ','LOPEZ',' CALDERON','activo',2,'03' 
exec ingresarDiputado '0314197000143','LUIS ','RIGOBERTO ','SANTOS ','PORTILLO','activo',2,'03'
exec ingresarDiputado '0315197000144','JOSUE ','WILMER ','RIVAS ','MORENO','activo',2,'03'
exec ingresarDiputado '0316197000145','MARIO','JOS',' GAMALIEL','RIVERA ','activo',2,'03'
exec ingresarDiputado '0317197000146','CELENA ','SOFIA ','LEVY ','LEVY','activo',2,'03'
exec ingresarDiputado '0318197000147','RAUL','JOSUE',' MENDEZ ','CASTRO','activo',2,'03'
-------------Partido anticorrupcion----
exec ingresarDiputado '0317197000148','PEDRO ','ANTONIA',' MEZA ','PONCE','activo',3,'03'
exec ingresarDiputado '0316197000149','KEREN',' MARIA ','ARANDA ','QUINTANA','activo',3,'03'
exec ingresarDiputado '0315197000150','MARIO ','ANTONIO ','GUERRA ','DEL CID','activo',3,'03'
exec ingresarDiputado '0314197000151','ANA ','MARIA ','PEREZ ','LOPEZ','activo',3,'03'
exec ingresarDiputado '0313197000152','GERARDO','ANTONIO',' VILLANUEVA ','CORTES','activo',3,'03'
exec ingresarDiputado '0312197000153','JUAN ','CARLOS',' VILLALOBOS ','ANDINO','activo',3,'03'
exec ingresarDiputado '0311197000154','LETICA',' MACARENA ','RAMOS ','CACERES','activo',3,'03'
exec ingresarDiputado '0310197000155','GENESIS ','NAHOMI ','CASTRO ','MORENO','activo',3,'03'
exec ingresarDiputado '0309197000156','RAMON',' ENRIQUE ','MARTINEZ',' MARTINEZ','activo',3,'03' 
-------------Partido ALiberal----
exec ingresarDiputado '0318197000157','YAFET ','CARLOS ','GOMEZ ','SABILLON','activo',4,'03'
exec ingresarDiputado '0309197000158','MARIA ','EUGENIA ','RAMOS ','LOPEZ','activo',4,'03'
exec ingresarDiputado '0308197000159','DENIA ','JOSEFA ','LOPEZ ','CACERES','activo',4,'03'
exec ingresarDiputado '0307197000160','WILMER ','ALEJANDRO ','FERNANDEZ ','CORTEZ','activo',4,'03'
exec ingresarDiputado '0306197000161','WALTER ','ERACIO ','RIVERA ','MENDEZ','activo',4,'03'
exec ingresarDiputado '0305197000162','EMERSON ','JOSUE ','LOPEZ ','GIRON','activo',4,'03'
exec ingresarDiputado '0304197000163','HECTOR ','ORLANDO ','PEREZ ','URIBE','activo',4,'03'
exec ingresarDiputado '0303197000164','ALEX ','ENRIQUE ','REYES ','MARTINEZ','activo',4,'03'
exec ingresarDiputado '0302197000165','JIMENA ','ALEXANDRA ','ELISONDO ','URIBE','activo',4,'03'
				

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
execute eliminarDiputado '0308197000157'
execute eliminarDiputado '0301197000130'
execute eliminarDiputado '0302197000131'
execute eliminarDiputado '0303197000132'
---------No existe Por lo tanto mostrara mensaje-----
exec eliminarDiputado '0311198000139'

	---------consultar-Diputado----
create procedure consultarDiputado
as
begin
select IdentidadDiputado as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo',VotosValidos,VotosNulos,voto,foto, D.nombreDepartamento as Departamento, p.NombrePartido as 'Partido Politico' from Diputado
inner join PartidoPolitico p on Partido= p.idPartido
inner join Departamento D on Departamento = D.idDepartamento
where estado='activo'
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
	insert into votante(IdentidadVotante,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,edad,sexo,estadoVotante,voto)
values(@IdentidadVotante,@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,@edad,@sexo,@estadoVotante,'F')
end
execute IngresarVotante '0318200301323', 'Karla', 'Gissel', 'Lopez', 'Caceres',21,'Femenino','Activo'
execute IngresarVotante '0318200201281', 'Denia', 'Julissa', 'Chavarria', 'Lopez',20,'Femenino','Activo'
execute IngresarVotante '0318200301367', 'Abdiel', 'Jesus', 'Giron', 'Garcia',20,'Masculino','Activo'
execute IngresarVotante '0318200301368', 'Hector', 'Eduardo', 'Osorio', 'Castellanos',20,'Masculino','Activo'
execute IngresarVotante '0318200301030', 'ken', 'Jonathan', 'Gomez', 'Barrientos',21,'Masculino','Activo'

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

exec actualizarVotante '0318200301367', 'Abdiel', 'Jesus', 'Giron', 'Garcia',20,'Masculino'
------------No existe-----
exec actualizarVotante '0318200401323', 'Mario', 'Antonio', 'Guerra', 'Del cid',21,'Masculino'

select * from votante


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
exec eliminarVotante '0318200301030'

---------consultar-Votante----
Create procedure consultarVotante
as
begin
select IdentidadVotante as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', edad,sexo,voto,foto from votante
where estadoVotante='activo'
end
exec consultarVotante

----------------------------------------------------------------------ADMIN-----------------------------------------------------------------------------------

---------Buscar Individualmente----
create procedure buscarIndividual(
@Identidad varchar(13)
)
as
begin
if exists(select IdentidadPresidente from Presidente where IdentidadPresidente = @Identidad and estado='activo')
	select IdentidadPresidente as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', p.NombrePartido as 'Partido Politico', 
	VotosValidos, VotosNulos,voto, foto from Presidente
	inner join PartidoPolitico p on Partido= p.idPartido

else if exists(select IdentidadDiputado from Diputado where IdentidadDiputado = @Identidad and estado='activo')
	select IdentidadDiputado as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo',
	VotosValidos, VotosNulos,voto,foto,D.nombreDepartamento as Departamento, p.NombrePartido as 'Partido Politico' from Diputado
    inner join PartidoPolitico p on Partido= p.idPartido
    inner join Departamento D on Departamento = D.idDepartamento
	
else if exists(select IdentidadAlcalde from Alcalde where IdentidadAlcalde = @Identidad and estado='activo')
	select IdentidadAlcalde as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo',
	VotosValidos, VotosNulos,voto, foto,M.nombreMunicipio as Municipio, D.nombreDepartamento as Departamento , p.NombrePartido as 'Partido Politico' from Alcalde
	inner join PartidoPolitico p on Partido= p.idPartido
	inner join Municipio M on Municipio = M.idMunicipio
	inner join Departamento D on M.idDepartamento = D.idDepartamento

else if exists(select IdentidadVotante from votante where IdentidadVotante = @Identidad and estadoVotante='activo')
	select IdentidadVotante as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo',edad, sexo, foto, estadoVotante as 'Estado',voto from votante
else
	raiserror('Esta persona no existe en la base de datos',16,1)
end

exec buscarIndividual '0318200301323'


	------Procedimiento almacenado-----
	------Buscar por identidad--------
Create procedure validarVotante(@IdentidadVotante varchar(13))
as
begin
select estadoVotante from votante where IdentidadVotante = @IdentidadVotante
end
execute validarVotante '0318200301323'
----------------------------------------------------agregar foto------------------------------
create procedure ingresarFoto(
@imagen image, 
@identidad varchar(13)
)
as 
begin
if exists(select IdentidadPresidente from Presidente where IdentidadPresidente = @identidad)
	update presidente set foto = @imagen

else if exists(select IdentidadDiputado from Diputado where IdentidadDiputado = @identidad)
	update Diputado set foto = @imagen
	
else if exists(select IdentidadAlcalde from Alcalde where IdentidadAlcalde = @identidad)
	update Alcalde set foto = @imagen

else if exists(select IdentidadAlcalde from Alcalde where IdentidadAlcalde = @identidad)
	update administrador set foto = @imagen
else
	raiserror('Esta persona no existe en la base de datos',16,1)

end
-------------------------------------------------validar usuario-------------------------------------
------------------------------------Procedimiento almacenado validar administrador-------------
create procedure validaradministrador(
@identidad varchar (13),
@contraseña varchar (15)
)
as begin
if exists (select estado from administrador where identidad = @identidad and contraseña = @contraseña and estado = 'activo')
	raiserror('encontrado',16,1)
else
	raiserror('No encontrado',16,1)
end
