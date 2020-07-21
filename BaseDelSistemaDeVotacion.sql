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
	insert into PartidoPolitico (idPartido,NombrePartido,lema)
	values 
	(1,'Partido Nacional','Vamos hacer lo que tengamos que hacer'),
	(2,'Partido Libre','Por una Honduras mejor'),
	(3,'Partido AntiCorrupcion','Para Combatir la corrupcion'),
	(4,'Partido Liberal','Por un futuro mejor')

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
	idMunicipio varchar(4) not null primary key,
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
	Municipio varchar(4) FOREIGN KEY REFERENCES Municipio(idMunicipio)
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
	CodMunicipio varchar(4) FOREIGN KEY REFERENCES Municipio(idMunicipio)
	)

	---------------Procedimientos-Almacenados----

	---------Insertar-Presidente----
	create procedure ingresarPresidente(
	@PrimerNombre varchar(25),
	@segundoNombre varchar(25),
	@PrimerApellido varchar(25),
	@SegundoApellido varchar(25),
	@Estado varchar(25),
	@Partido char(1)
	)
	as
	begin
	if exists(select PrimerNombre from Presidente where PrimerNombre=@PrimerNombre and PrimerApellido=@PrimerApellido)
		raiserror('El Presidente ya existe, Ingrese otro',16,1)
	else 
		insert into Presidente( PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,Estado,Partido)
		values(@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@Estado,@Partido)
	end

		exec ingresarPresidente 'Juan','Orlando','Hernandez','Alvarado','activo',1
		exec ingresarPresidente 'Luis','Orlando','Zelaya','Medrano ','activo',2 
		exec ingresarPresidente 'Salvador','Alejandro','Nasralla','Salum ','activo',3
		exec ingresarPresidente 'Jose','Manuel','Zelaya','Rosales','activo',4
		

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
		where idPresidente = @idPresidente
	end
	exec eliminarPresidente 1

	---------consultar-Presidente----
	create procedure consultarPresidente
	as
	begin
	select idPresidente as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', p.NombrePartido as 'Partido Politico' from Presidente
	inner join PartidoPolitico p on Partido= p.idPartido
	end


	-------Procedimientos Almacenados-----
	-------Insertar--Alcalde--
	create procedure ingresarAlcalde
	(
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
	if exists(select PrimerNombre from Alcalde where PrimerNombre=@PrimerNombre and PrimerApellido=@PrimerApellido)
		raiserror('El Alcalde ya existe, Ingrese otro',16,1)
	else 
		insert into Alcalde( PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,DescripcionVotacion,Estado,Partido,Municipio)
		values(@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@DescripcionVotacion,@Estado,@Partido,@Municipio)
	end
	
	--------Municipio de Comayagua----------
	--Partido Nacional
	execute ingresarAlcalde 'Carlos', 'Josue', 'Miranda', 'Canales', 'interna', 'activo', 1, 0301
	execute ingresarAlcalde 'Trinidad', 'Jose ', 'cecilio', 'del Valle', 'interna', 'activo', 1, 0301
	--Partido liberal
	execute ingresarAlcalde 'Juan', 'Carlos', 'Juarez', 'Gutierrez', 'interna', 'activo', 2, 0301
	execute ingresarAlcalde 'Pedro', 'Rafael ', 'Valladarez', 'Giron', 'interna', 'activo', 2, 0301
	--Partido Anticorrupcion
	execute ingresarAlcalde 'Jose', 'Francisco', 'Hernandez', 'Canales', 'interna', 'activo', 3, 0301
	execute ingresarAlcalde 'Joseph', 'Josias ', 'Caceres', 'Rivas', 'interna', 'activo', 3, 0301
	--Partido Libre
	execute ingresarAlcalde 'Edgar', 'Orlando', 'Gutierrez', 'Guzman', 'interna', 'activo', 4, 0301
	execute ingresarAlcalde 'Ever', 'Jose ', 'Morazan', 'Dominguez', 'interna', 'activo', 4, 0301
	
	--------Municipio de Ajuterique----------
	--Partido Nacional
	execute ingresarAlcalde 'Pedro', 'Alonso', 'Mosku', 'Canales', 'interna', 'activo', 1, 0302
	execute ingresarAlcalde 'Rey', 'Alonso ', 'Vasquez', 'Juarez', 'interna', 'activo', 1, 0302
	--Partido liberal
	execute ingresarAlcalde 'Alberto', 'Jacob', 'Perez', 'Sambrano', 'interna', 'activo', 2, 0302
	execute ingresarAlcalde 'Feliciano', 'Roberto ', 'Pineda', 'Garcia', 'interna', 'activo', 2, 0302
	--Partido Anticorrupcion
	execute ingresarAlcalde 'Ricardo', 'Alfonso', 'Guerra', 'Guerra', 'interna', 'activo', 3, 0302
	execute ingresarAlcalde 'Edgardo', 'Butin ', 'Prada', 'Rodriguez', 'interna', 'activo', 3, 0302
	--Partido Libre
	execute ingresarAlcalde 'Kevin', 'Leonel', 'Lopez', 'Lopez', 'interna', 'activo', 4, 0302
	execute ingresarAlcalde 'Oscar', 'Rafael ', 'Llamazares', 'Caceres', 'interna', 'activo', 4, 0302

	--------Municipio El Rosario----------
	--Partido Nacional
	execute ingresarAlcalde 'Miguel', 'Fernando', 'Mosku', 'Canales', 'interna', 'activo', 1, 0303
	execute ingresarAlcalde 'Juan', 'Alonso ', 'Hernadez', 'Hernadez', 'interna', 'activo', 1, 0303
	--Partido liberal
	execute ingresarAlcalde 'Alberto', 'Josias', 'Pacheco', 'Sambrano', 'interna', 'activo', 2, 0303
	execute ingresarAlcalde 'Celio', 'Roberto ', 'Pineda', 'Manzanares', 'interna', 'activo', 2, 0303
	--Partido Anticorrupcion
	execute ingresarAlcalde 'Mercedes', 'Maria', 'Aranda', 'Gomez', 'interna', 'activo', 3, 0303
	execute ingresarAlcalde 'Mario', 'Arturo ', 'Espinoza', 'Cruz', 'interna', 'activo', 3, 0303
	--Partido Libre
	execute ingresarAlcalde 'Francisco', 'Javier', 'Varela', 'Rosa', 'interna', 'activo', 4, 0303
	execute ingresarAlcalde 'Miguel', 'Angel ', 'Rodriguez', 'Funez', 'interna', 'activo', 4, 0303

	-------Procedimientos Almacenados-----
	---------Actualizar-Alcalde----
	create procedure actualizarAlcalde(
	@idAlcalde int,
	@PrimerNombre varchar(25),
	@SegundoNombre varchar(25),
	@PrimerApellido varchar(25),
	@SegundoApellido varchar(25),
	@Estado varchar(25),
	@Partido int,
	@Municipio varchar(2)
	)
	as 
	begin
	update Alcalde 
	set PrimerNombre = @PrimerNombre, SegundoNombre = @segundoNombre, PrimerApellido = @PrimerApellido,SegundoApellido = @SegundoApellido,Estado = @Estado, Partido = @partido, Municipio = @Municipio
	where idAlcalde =@idAlcalde
	end

	---------Eliminar-Alcalde----
	create procedure eliminarAlcalde(
	@idAlcalde int
	)
	as
	begin
	if exists(select estado,idAlcalde from Alcalde where idAlcalde = @idAlcalde and Estado='eliminado')
		raiserror ('el Alcalde no existe en la base de datos',16,1)
	else
		update Alcalde
		set Estado = 'eliminado'
		where idAlcalde=@idAlcalde

	end
	exec eliminarPresidente 1



	---------consultar-Alcalde----
	create procedure consultarAlcalde
	as
	begin
	select idAlcalde as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo',M.nombreMunicipio as Municipio, D.nombreDepartamento as Departamento , p.NombrePartido as 'Partido Politico' from Alcalde
	inner join PartidoPolitico p on Partido= p.idPartido
	inner join Municipio M on Municipio = M.idMunicipio
	inner join Departamento D on M.idDepartamento = D.idDepartamento
	end


	-------Procedimientos Almacenados-----
	----------insertar Diputado--------

	create procedure ingresarDiputado(
	@PrimerNombre varchar(25),
	@SegundoNombre varchar(25),
	@PrimerApellido varchar(25),
	@SegundoApellido varchar(25),
	@Estado varchar(25),
	@partido int,
	@Departamento varchar(2)
	)
	as begin
	if exists(select PrimerNombre from Diputado where PrimerNombre=@PrimerNombre and PrimerApellido=@PrimerApellido)
		raiserror('El Diputado ya existe, Ingrese otro',16,1)
	else 
		insert into Diputado( PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,VotosValidos,VotosNulos,Estado,Partido,Departamento)
		values(@PrimerNombre,@segundoNombre,@PrimerApellido,@SegundoApellido,'0','0',@Estado,@Partido,@Departamento)
	end 

		exec ingresarDiputado 'Oscar','Aturo','Alvarez','Guerrero','activo','Partido Nacional','Francisco Morazan' -----------1
		exec ingresarDiputado 'HECTOR ','GUILLERMO',' GUILLEN ','GOMEZ','activo','Partido Nacional','Cortes'------------------2
		exec ingresarDiputado 'JOSE ','TOMAS ','PONCE ','POSAS','activo','Partido liberal','Yoro '----------------------------3
		exec ingresarDiputado 'MARTHA ','CONCEPCION ','FIGUEROA',' TORREZ','activo','Partido Nacional','Santa Barbara'--------4
		exec ingresarDiputado 'JUAN ','FRANCISCO ','ARGEÑAL',' ESPINAL','activo','Partido Nacional','Choluteca'---------------5
		exec ingresarDiputado 'RAMON ','ANTONIO ','LEVA ','BULNES','activo','Partido Nacional','Atlantida'--------------------6
		exec ingresarDiputado 'JOSE',' MARIA ','MARTINEZ ','VALENZUELA','activo','Partido Nacional','Comayagua'---------------7
		exec ingresarDiputado 'JOSE ','VICENTE',' LEON ','ROJAS','activo','Partido Nacional','Copan'--------------------------8
		exec ingresarDiputado 'REINALDO ','ANTONIO ','SANCHEZ',' RIVERA','activo','Partido Nacional','Olancho'----------------9
		exec ingresarDiputado 'JOSE ','CELIN',' DISCUA ','ELVIR','activo','Partido Nacional','El Paraiso'---------------------10
		exec ingresarDiputado 'JUAN','CARLOS',' VALENZUELA ','MOLINA','activo','Partido Nacional','Lempira'-------------------11
		exec ingresarDiputado 'MIDENCE ','OQUELY',' MARTINEZ ','TURCIOS','activo','Partido Libre','Colon'---------------------12
		exec ingresarDiputado 'ANA',' JULIA ','GARCIA ','VILLALOBOS','activo','Partido Nacional','Valle'----------------------13
		exec ingresarDiputado 'FELIPE ','ZUNIGA ','DEL ','CID','activo','Partido liberal','Intibuca'--------------------------14
		exec ingresarDiputado 'GLADIS',' AURORA ','LOPEZ',' CALDERON','activo','Partido Nacional','La paz' -------------------15
		exec ingresarDiputado 'LUIS ','RIGOBERTO ','SANTOS ','PORTILLO','activo','Partido libre','Ocotepeque'-----------------16
		exec ingresarDiputado 'GEORGE ','ROMEO ','SILVESTRI ','FEREZ','activo','Partido Nacional','Islas de la bahia'---------17
		exec ingresarDiputado 'MAYLO','WOOD',' GRANWELL',' ','activo','Partido Nacional','Gracias a Dios'---------------------18

		select * from Diputado

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
	select idDiputado as 'ID',  CONCAT(PrimerNombre,' ',SegundoNombre,' ',PrimerApellido,' ',SegundoApellido) as 'Nombre Completo', D.nombreDepartamento as Departamento, p.NombrePartido as 'Partido Politico' from Diputado
	inner join PartidoPolitico p on Partido= p.idPartido
	inner join Departamento D on Departamento = D.idDepartamento
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


-----Ingreso Departamentos ------
insert into Departamento(idDepartamento,nombreDepartamento)
values
('01','Atlántida')
('02','Colón')
('03','Comayagua')
('04','Copán')
('05','Cortés')
('06','Choluteca')
('07','Paraíso')
('08','Francisco Morazán')
('09','Gracias a Dios')
('10','Intibucá')
('11','Islas de La Bahía')
('12','La Paz')
('13','Lempira')
('14','Ocotepeque')
('15','Olancho')
('16','Santa Bárbara')
('17','Valle')
('18','Yoro')

----Ingreso Muicipios
insert into Municipio(idMunicipio,nombreMunicipio,idDepartamento)
values
--Atlántida
('0101','La Ceiba','01'),
('0102','El Porvenir','01')
('0103','El Porvenir','01')
('0104','Jutiapa ','01')
('0105','La Masica','01')
('0106','San Francisco','01')
('0107','Tela','01')
('0108','Arizona','01')
--Colón
('0201','Trujillo ','02')
('0202','Balfate  ','02')
('0203','Iriona ','02')
('0204','Limón ','02')
('0205','Sabá ','02')
('0206','Santa Fe ','02')
('0207','Santa Rosa de Aguán','02')
('0208','Sonaguera ','02')
('0209','Tocoa ','02')
('0210','Bonito Oriental ','02')
--Comayagua
('0301','Comayagua','03')
('0302','Ajuterique','03')
('0303','El Rosario','03')
('0304','Esquías','03')
('0305','Humuya','03')
('0306','La Libertad','03')
('0307','Lamaní','03')
('0308','La Trinidad','03')
('0309','Lejamaní','03')
('0310','Meámbar','03')
('0311','Minas de Oro','03')
('0312','Ojos de Agua','03')
('0313','San Jerónimo','03')
('0314','San José de Comayagua','03')
('0315','San José del Potrero','03')
('0316','San Luis ','03')
('0317','San Sebastián','03')
('0318','Siguatepeque','03')
('0319','Villa de San Antonio','03')
('0320','Las Lajas','03')
('0321','Taulabé','03')
--Copán
('0401','Santa Rosa de Copán','04')
('0402','Cabañas','04')
('0403','Concepción','04')
('0404','Copán Ruinas','04')
('0405','Corquín ','04')
('0406','Cucuyagua ','04')
('0407','Dolores','04')
('0408','Dulce Nombre','04')
('0409','El Paraíso ','04')
('0410','Florida','04')
('0412','La Jigua ','04')
('0412','La Unión','04')
('0413','Nueva Arcadia','04')
('0414','San Agustín ','04')
('0415','San Antonio ','04')
('0416','San Jerónimo','04')
('0417','San José ','04')
('0418','San Juan de Opoa','04')
('0419','San Nicolás','04')
('0420','San Pedro ','04')
('0421','Santa Rita','04')
('0422','Trinidad de Copán','04')
('0423','Veracruz ','04')
--Cortés
('0501''San PedroSula' '05')
('0502''Choloma''05')
('0503''Omoa' '05')
('0504''Pimienta''05' )
('0505''Potrerillos''05') 
('0506''Puerto Cortés''05') 
('0507''San Antonio de Cortés''05') 
('0508''San Francisco de Yojoa''05') 
('0509''San Manuel''05') 
('0510''Santa Cruz de Yojoa''05')
('0511''Villanueva''05')
('0512''La Lima''05') 
--Choluteca
('0601' 'Choluteca''06')
('0602' 'Apacilagua''06') 
('0603' 'Concepción de María''06') 
('0604' 'Duyure' '06')
('0605' 'El Corpus''06') 
('0606' 'El Triunfo''06') 
('0607' 'Marcovia''06') 
('0608' 'Morolica''06') 
('0609' 'Namasigüe''06') 
('0610' 'Orocuina''06') 
('0611' 'Pespire')'06' 
('0612' 'San Antonio de Flores''06') 
('0613' 'San Isidro''06' )
('0614' 'San José''06') 
('0615' 'San Marcos de Colón''06') 
('0616' 'Santa Ana de Yusguare''06')
--Paraíso
('0701' 'Yuscarán ''07')
('0702' 'Alauca ''07')
('0703' 'Danlí ''07')
('0704' 'El Paraíso''07')
('0705' 'Güinope ''07')
('0706' 'Jacaleapa ''07')
('0707' 'Liure ''07')
('0708' 'Morocelí''07')
('0709' 'Oropolí ''07')
('0710' 'Potrerillos ''07')
('0711' 'San Antonio de Flores ''07')
('0712' 'San Lucas''07')
('0713' 'San Matías ''07')
('0714' 'Soledad''07')
('0715' 'Teupasenti''07')
('0716' 'Texiguat''07')
('0717' 'Vado Ancho''07')
('0718' 'Yauyupe''07')
('0719' 'Trojes''07')
--Francisco Morazán
('0801' 'Distrito Central''08')
('0802' 'Alubarén ''08')
('0803' 'Cedros ''08')
('0804' 'Curarén ''08')
('0805' 'El Porvenir''08')
('0806' 'Guaimaca''08')
('0807' 'La Libertad''08')
('0808' 'La Venta ''08')
('0809' 'Lepaterique''08')
('0810' 'Maraita ''08')
('0811' 'Marale ''08')
('0812' 'Nueva Armenia''08')
('0813' 'Ojojona''08')
('0814' 'Orica''08')
('0815' 'Reitoca''08')
('0816' 'Sabanagrande''08')
('0817' 'San Antonio de Oriente ''08')
('0818' 'San Buenaventura ''08')
('0819' 'San Ignacio''08')
('0820' 'San Juan de Flores''08')
('0821' 'San Miguelito ''08')
('0822' 'Santa Ana''08')
('0823' 'Santa Lucía ''08')
('0824' 'Talanga ''08')
('0825' 'Tatumbla ''08')
('0826' 'Valle de Ángeles ''08')
('0827' 'Villa de San Francisco''08')
('0828' 'Vallecillo ''08')
--Gracias a Dios
('0901' 'Puerto Lempira''09')
('0902' 'Brus Laguna''09')
('0903' 'Ahuas''09')
('0904' 'Juan Francisco Bulnes''09')
('0905' 'Ramón Villeda Morales''09')
('0906' 'Wampusirpe''09')
--Intibucá
('1001','La Esperanza''10')
('1002','Camasca ''10')
('1003','Colomoncagua''10')
('1004','Concepción ''10')
('1005','Dolores''10')
('1006','Intibucá ''10')
('1007','Jesús de Otoro ''10')
('1008','Magdalena''10')
('1009','Masaguara''10')
('1010','San Antonio''10')
('1011','San Isidro ''10')
('1012','San Juan''10')
('1013','San Marcos de la Sierra''10')
('1014','San Miguel Guancapla ''10')
('1015','Santa Lucía ''10')
('1016','Yamaranguila ''10')
('1017','San Francisco de Opalaca''10')
--Islas de La Bahía
('1101' 'Roatán''11')
('1102' 'Guanaja ''11')
('1103' 'José Santos Guardiola ''11')
('1104' 'Utila''11')
--La Paz
('1201' 'La Paz ''12')
('1202' 'Aguanqueterique''12')
('1203' 'Cabañas''12')
('1204' 'Cane ''12')
('1205' 'Chinacla''12')
('1206' 'Guajiquiro ''12')
('1207' 'Lauterique ''12')
('1208' 'Marcala''12')
('1209' 'Mercedes de Oriente''12')
('1210' 'Opatoro''12')
('1211' 'San Antonio del Norte ''12')
('1212' 'San José''12')
('1213' 'San Juan''12')
('1214' 'San Pedro de Tutule ''12')
('1215' 'Santa Ana''12')
('1216' 'Santa Elena ''12')
('1217' 'Santa María''12')
('1218' 'Santiago de Puringla ''12')
('1219' 'Yarula ''12')
--Lempira
('1301' 'Gracias''13')
('1302' 'Belén ''13')
('1303' 'Candelaria''13')
('1304' 'Cololaca ''13')
('1305' 'Erandique ''13')
('1306' 'Gualcince ''13')
('1307' 'Guarita ''13')
('1308' 'La Campa ''13')
('1309' 'La Iguala ''13')
('1310' 'Las Flores ''13')
('1311' 'La Unión''13')
('1312' 'La Virtud ''13')
('1313' 'Lepaera ''13')
('1314' 'Mapulaca ''13')
('1315' 'Piraera ''13')
('1316' 'San Andrés ''13')
('1317' 'San Francisco ''13')
('1318' 'San Juan Guarita''13')
('1319' 'San Manuel Colohete ''13')
('1320' 'San Rafael ''13')
('1321' 'San Sebastián ''13')
('1322' 'Santa Cruz ''13')
('1323' 'Talgua''13')
('1324' 'Tambla ''13')
('1325' 'Tomalá ''13')
('1326' 'Valladolid''13')
('1327' 'Virginia ''13')
('1328' 'San Marcos de Caiquín ''13')
--Ocotepeque
('1401' 'Nueva Ocotepeque''14')
('1402' 'Belén Gualcho ''14')
('1403' 'Concepción ''14')
('1404' 'Dolores Merendón ''14')
('1405' 'Fraternidad ''14')
('1406' 'La Encarnación ''14')
('1407' 'La Labor''14')
('1408' 'Lucerna''14')
('1409' 'Mercedes ''14')
('1410' 'San Fernando ''14')
('1411' 'San Francisco del Valle''14')
('1412' 'San Jorge''14')
('1413' 'San Marcos''14')
('1414' 'Santa Fe ''14')
('1415' 'Sensenti ''14')
('1416' 'Sinuapa ''14')
--Olancho
('1501' 'Juticalpa  ''15')
('1502' 'Campamento ''15')
('1503' 'Catacamas  ''15')
('1504' 'Concordia  ''15')
('1505' 'Dulce Nombre de Culmí   ''15')
('1506' 'El Rosario  ''15')
('1507' 'Esquipulas del Norte  ''15')
('1508' 'Gualaco   ''15')
('1509' 'Guarizama   ''15')
('1510' 'Guata   ''15')
('1511' 'Guayape  ''15')
('1512' 'Jano   ''15')
('1513' 'La Unión  ''15')
('1514' 'Mangulile  ''15')
('1515' 'Manto   ''15')
('1516' 'Salamá   ''15')
('1517' 'San Esteban  ''15')
('1518' 'San Francisco de Becerra  ''15')
('1519' 'San Francisco de la Paz  ''15')
('1520' 'Santa María del Real   ''15')
('1521' 'Silca''15')
('1522' 'Yocón ''15')
('1523' 'Patuca ''15')
--Santa Bárbara
('1601' 'Santa Bárbara''16')
('1602' 'Arada  ''16')
('1603' 'Atima ''16')
('1604' 'Azacualpa  ''16')
('1605' 'Ceguaca ''16')
('1606' 'San José de las Colinas ''16')
('1607' 'Concepción del Norte  ''16')
('1608' 'Concepción del Sur  ''16')
('1609' 'Chinda  ''16')
('1610' 'El Níspero''16')
('1611' 'Gualala ''16')
('1612' 'Ilama ''16')
('1613' 'Macuelizo ''16')
('1614' 'Naranjito  ''16')
('1615' 'Nuevo Celilac ''16')
('1616' 'Petoa  ''16')
('1617' 'Protección ''16')
('1618' 'Quimistán  ''16')
('1619' 'San Francisco de Ojuera  ''16')
('1620' 'San Luis  ''16')
('1621' 'San Marcos  ''16')
('1622' 'San Nicolás  ''16')
('1623' 'San Pedro Zacapa  ''16')
('1624' 'Santa Rita  ''16')
('1625' 'San Vicente Centenario ''16')
('1626' 'Trinidad ''16')
('1627' 'Las Vegas ''16')
('1628' 'Nueva Frontera  ''16')
--Valle
('1701' 'Alianza  ''17')
('1701' 'Amapala  ''17')
('1701' 'Aramecina  ''17')
('1701' 'Caridad  ''17')
('1701' 'Goascorán ''17')
('1701' 'Langue ''17')
('1701' 'Nacaome  ''17')
('1701' 'San Francisco de Coray ''17')
('1701' 'San Lorenzo  ''17')
--Yoro
('1801' 'Yoro ''18')
('1802' 'Arenal ''18')
('1803' 'El Negrito ''18')
('1804' 'El Progreso''18')
('1805' 'Jocón ''18')
('1806' 'Morazán ''18')
('1807' 'Olanchito ''18')
('1808' 'Santa Rita ''18')
('1809' 'Sulaco''18')
('1810' 'Victoria''18')
('1811' 'Yorito ''18')
