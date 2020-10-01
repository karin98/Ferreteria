use Ferreterias
go
------------------------------
create procedure MostrarCliente
as 
select * from Cliente
order by CodCliente desc
go


------------------------------
go
create proc CrearCliente
@CodC varchar (20),
@NombreC varchar (30),
@ApellidosC varchar (30),
@DireccionC varchar (30),
@CelC varchar (30),
@Dni varchar (30)
as
insert into Cliente (CodCliente,NombreCliente,ApellidosCliente,DireccionCliente,CelCliente,DniCliente) 
values (@CodC,@NombreC,@ApellidosC,@DireccionC,@CelC, @Dni)
go

------------------------------
create proc EditarCliente
@CodC varchar (20),
@NombreC varchar (30),
@ApellidosC varchar (30),
@DireccionC varchar (30),
@CelC varchar (30)

as
update Cliente set  NombreCliente=@NombreC, ApellidosCliente=@ApellidosC,
DireccionCliente=@DireccionC,CelCliente=@CelC
where CodCliente=@CodC
go 
------------------------------
create proc EliminarCliente
@pCodCliente varchar (20)
AS
DELETE
FROM Cliente
WHERE CodCliente=@pCodCliente
GO

------------------------------
CREATE PROCEDURE BuscarCliente
@dni varchar (30)
AS
SELECT CodCliente,NombreCliente,ApellidosCliente,DireccionCliente,CelCliente,DniCLiente   from Cliente 
WHERE DniCLiente  LIKE @dni+ '%' 

exec BuscarCliente 'Gomez'