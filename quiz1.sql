create database quiz1
go
use quiz1
go


create table escuela(
escuelaID int identity primary key,
NombreEscuela varchar(50)not null,
descripcion varchar(100)null,
correo varchar(50)null,
telefono varchar(50)null,
codigopostal varchar(50)null,
direccionPostal varchar(50)null
)
insert into escuela values('b','n','h','9','k','c')
select * from escuela
create table clase(
claseID int identity primary key,
nombreClase varchar(50)not null,
descripccion varchar(1000)null,
escuelaID int foreign key references escuela(escuelaID)
)
insert into clase values('c','fds',1)
select *from clase
create procedure AgregarEscuela

@nombreEscuela varchar(50),
@descripcion varchar(100),
@correo varchar(50),
@telefono varchar(50),
@codigopostal varchar(50),
@direccionPostal varchar(50)
as 
begin
insert into escuela values (@nombreEscuela,@descripcion,@correo,@telefono,@codigopostal,@direccionPostal)

end


create procedure borararEscuela
@id int
as
begin
delete escuela where escuelaID=@id

end

create procedure modificarEscuela
@id int,
@nombreEscuela varchar(50),
@descripcion varchar(100),
@correo varchar(50),
@telefono varchar(50),
@codigopostal varchar(50),
@direccionPostal varchar(50)
as 
begin
update escuela set NombreEscuela=@nombreEscuela,descripcion=descripcion,correo=@correo,telefono=@telefono,codigopostal=@codigopostal,direccionPostal=@direccionPostal where escuelaID=@id

end
create procedure consultarescuela
@id int
as 

begin
select * from escuela where escuelaID=@id
end

create procedure AgregarClase

@nombreClase varchar(50),
@descripcion varchar(1000),
@escuelaID int
as 
begin
insert into clase values (@nombreClase,@descripcion,@escuelaID)

end

create procedure borararClase
@id int
as
begin
delete clase where claseID=@id

end
create procedure modificarClase
@id int,
@nombreClase varchar(50),
@descripcion varchar(1000),
@escuelaID int
as 
begin
update clase set nombreClase=@nombreClase,descripccion=@descripcion where claseID=@id

end
create procedure consultarClase
@id int
as 

begin
select * from clase where claseID=@id
end