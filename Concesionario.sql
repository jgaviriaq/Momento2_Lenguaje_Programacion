create database concesionario

use concesionario

create table tipo_vehiculo
(
	id  int primary key,
	nombre varchar(25)
)

create procedure add_TipoVehiculo
(
	@id int,
	@nombre varchar(25)
)
	as
		insert into tipo_vehiculo values(@id,@nombre)

select * from tipo_vehiculo
Execute add_TipoVehiculo 1,'Camion'


create procedure updateTipoVehiculo 
(
	@id int,
	@nombre varchar(25)
)
	as
		update tipo_vehiculo set nombre = @nombre where id = @id

select * from tipo_vehiculo
Execute updateTipoVehiculo 4,'motocicletas' 


create proc deleteTipoVehiculo 
(
	@id int
)
as delete from tipo_vehiculo where id = @id;


/********************************************************/
create table Vehiculo
(
	id  int primary key,
	marca varchar(25) unique,
	modelo varchar(25) not null,
	placa varchar(6) not null,
	anio int not null,
	id_tipo_vehiculo int not null,
	constraint rel_a_tipovehiculo foreign key (id_tipo_vehiculo) references tipo_Vehiculo(id),
	
)

create procedure addVehiculo
(
	@id  int,
	@marca varchar(25),
	@modelo varchar(25),
	@placa varchar(6),
	@anio int,
	@id_tipo_vehiculo int
)
	as 
		insert into Vehiculo values(@id, @marca, @modelo, @placa, @anio, @id_tipo_vehiculo)

select * from Vehiculo
Execute addVehiculo 2,'Chevrolet','CX3', 'asd123', 2019,1


create procedure updateVehiculo 
(
	@id int,
	@marca varchar(25),
	@modelo varchar(25),
	@placa varchar(6),
	@anio int,
	@id_tipo_vehiculo int
)
	as
		update Vehiculo set marca = @marca,modelo= @modelo,placa= @placa,anio = @anio, id_tipo_vehiculo = @id_tipo_vehiculo where id = @id


create proc deleteVehiculo 
(
	@id int
)
as delete from Vehiculo where id = @id;



/********************************************************/
create table tipo_conductor
(
	id int primary key,
	tipo_persona varchar(25)
)

create procedure add_tipo_conductor
(
	@id int,
	@tipo_persona varchar(25)
)
	as
		insert into tipo_conductor values(@id,@tipo_persona)

select * from tipo_conductor
Execute add_tipo_conductor 1,'taxista'


create procedure updateTipoConductor 
(
	@id int,
	@tipo_persona varchar(25)
)
	as
		update tipo_conductor set tipo_persona = @tipo_persona where id = @id


alter procedure deleteTipoConductor 
(
	@id int
)
as delete from tipo_conductor where id = @id;


/********************************************************/
create table conductor
(
	id int primary key,
	nombre varchar(25),
	tipo_licencia varchar(25),
	id_vehiculo int,
	id_tipo_conductor int

	constraint rel_a_tipo_conductor foreign key (id_tipo_conductor) references tipo_conductor(id),
	constraint rel_a_vehiculo foreign key (id_vehiculo) references vehiculo(id)
)

create procedure add_conductor
(
	@id  int,
	@nombre varchar(25),
	@tipo_licencia varchar(25),
	@id_vehiculo int,
    @id_tipo_conductor int
)
	as 
	insert into conductor values(@id, @nombre, @tipo_licencia, @id_vehiculo, @id_tipo_conductor)

	select * from conductor
    Execute add_conductor 1,'julian','a1', 2, 1

	create procedure updateConductor 
(
	@id int,
	@nombre varchar(25),
	@tipo_licencia varchar(25),
	@id_vehiculo int,
	@id_tipo_conductor int
)
 as
	update conductor set nombre = @nombre,tipo_licencia= @tipo_licencia,id_vehiculo= @id_vehiculo, id_tipo_conductor = @id_tipo_conductor where id = @id


	create proc deleteConductor 
(
	@id int
)
as delete from conductor where id = @id;

/********************************************************/
create table contrato
(
	id int primary key,
	id_conductor int references conductor(id),
	id_vehiculo int references vehiculo(id)
)


create procedure add_contrato
(
	@id int,
	@id_conductor int,
	@id_vehiculo int
)
	as
		insert into contrato values(@id, @id_conductor, @id_vehiculo)

select * from contrato
Execute add_contrato 1,1,2


create procedure updateContrato 
(
	@id int,
	@id_conductor int,
	@id_vehiculo int
)
	as
		update contrato set id_conductor = @id_conductor, id_vehiculo = @id_vehiculo where id = @id


create proc deleteContrato
(
	@id int
)
as delete from contrato where id = @id;


/********************************************************/
create table ruta
(
	id int primary key,
	estacion varchar(25),
	id_vehiculo int references vehiculo(id)
)

create procedure add_ruta
(
@id int,
@estacion varchar(25),
@id_vehiculo int
)
	as
		insert into ruta values(@id, @estacion, @id_vehiculo)
 
 select * from ruta
 Execute add_ruta 1,'poblado',2


 create procedure updateRuta 
(
	@id int,
	@estacion varchar(25),
	@id_vehiculo int
)
	as
		update ruta set estacion= @estacion, id_vehiculo = @id_vehiculo where id = @id


alter proc deleteRuta
(
	@id int
)
as delete from ruta where id = @id;

