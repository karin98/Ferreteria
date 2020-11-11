use Ferreterias

select * from trabajador
--TRABAJADOR
go
create proc TrabajadorMostrar
as 
select 
CodTrabajador as Codigo   ,
NombreTrabajador as Nombre ,
ApellidoTrabajador as Apellido ,
DireccionTrabajador as Direccion,
CelTrabajador as Celular,
DniTrabajador as Dni,
EmailTrabajador as Correo,
cargoTrabajador as Cargo ,
UsuTrabajador as Usuario ,
PassTrabajador as Contraseña,
TipoUsuTrabajador as TipoUsuario from Trabajador
go

exec TrabajadorMostrar 

go
create procedure TrabajadorCrear (
@CodTrabajador varchar (20)  ,
@NombreTrabajador varchar (30) ,
@ApellidoTrabajador varchar (30) ,
@DireccionTrabajador varchar (30) ,
@CelTrabajador varchar (10) ,
@DniTrabajador int  ,
@EmailTrabajador varchar (30) ,
@cargo_trabajador  varchar (30) ,
@UsuTrabajador  varchar (30)  ,
@PassTrabajador varchar (30) ,
@TipoUsuTrabajador varchar (30)) 
as 
insert into Trabajador (
CodTrabajador,
NombreTrabajador,
ApellidoTrabajador,
DireccionTrabajador,
CelTrabajador,
DniTrabajador,
EmailTrabajador,
cargoTrabajador,
UsuTrabajador,
PassTrabajador,
TipoUsuTrabajador)
values (
@CodTrabajador,
@NombreTrabajador,
@ApellidoTrabajador,
@DireccionTrabajador,
@CelTrabajador,
@DniTrabajador,
@EmailTrabajador,
@cargo_trabajador,
@UsuTrabajador,
@PassTrabajador,
@TipoUsuTrabajador)
go


exec TrabajadorCrear 'FSO01','SOYRI','LLAJA MIRANO','AV. LAS PERAS 456 SJL','970567456','70453465','soyrillaja@gmail.com',
'ADMINISTRADOR','FLLAJA','987650',''
go

EXEC TrabajadorMostrar


------------------------------
select * from Trabajador

go
create proc EditarTrabajador
@CodT varchar (20),
@NombreT varchar (30),
@ApellidosT varchar (30),
@DireccionT varchar (30),
@CelT varchar (10),
@Email varchar (30),
@Cargo varchar (30),
@Password varchar (30),
@TipoUs varchar (30)
as
update Trabajador  set NombreTrabajador =@NombreT , ApellidoTrabajador =@ApellidosT ,
DireccionTrabajador =@DireccionT ,CelTrabajador =@CelT ,EmailTrabajador =@Email , cargoTrabajador=@Cargo , PassTrabajador = @Password,
TipoUsuTrabajador= @TipoUs
where CodTrabajador=@CodT
go 

------------------------------
create proc EliminarTrabajador
@CodT varchar (20)
AS
DELETE
FROM Trabajador 
WHERE CodTrabajador =@CodT 
GO
------------------------------
CREATE PROCEDURE BuscarTrabajador
@dni varchar (30)
AS
select 
CodTrabajador as Codigo   ,
NombreTrabajador as Nombre ,
ApellidoTrabajador as Apellido ,
DireccionTrabajador as Direccion,
CelTrabajador as Celular,
DniTrabajador as Dni,
EmailTrabajador as Correo,
cargoTrabajador  AS Cargo,
UsuTrabajador as Usuario ,
PassTrabajador as Contraseña,
TipoUsuTrabajador as TipoUsuario from Trabajador
WHERE DniTrabajador  LIKE @dni+ '%' 

-------------------------------------------------------------------

--CREATE PROCEDURE sp_ValidarUsuario (
--	@Usuario VARCHAR(100)
--	,@ClaveAcceso VARCHAR(100)
--	)
--AS
--SELECT IdUsuario
--	,Nombre
--	,Apellido
--	,TipoDocumento
--	,DocumentoIdentidad
--	,Telefono
--	,Celular
--	,TipoUsuario
--	,Usuario
--	,ClaveAcceso
--FROM E_Usuario
--WHERE Usuario = @Usuario
--	AND ClaveAcceso = @ClaveAcceso
--GO
-----------------------------------------
go
CREATE PROCEDURE sp_ValidarUsuario (
	@Usuario VARCHAR(30)
	,@ClaveAcceso VARCHAR(30)
	)
AS
SELECT * FROM Trabajador
WHERE UsuTrabajador = @Usuario
	AND PassTrabajador = @ClaveAcceso
GO

exec sp_ValidarUsuario 'FLLAJA','987650'