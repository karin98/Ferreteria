use Ferreterias
-- **VENTAS**----

--go
-- create proc MostrarVenta
-- as
--select  trabajador.CodTrabajador,trabajador.NombreTrabajador, venta.codcliente as CodCliente , venta.FechaVenta as fecha  from venta
--inner join Trabajador on trabajador.CodTrabajador=Venta.CodTrabajador 
--order by CodVenta desc
--go
--------------

----*DETALLE DE VENTA *

--select DetalleVenta.codVenta as CodigoVenta,producto.NombreProducto,DetalleVenta.CantidadDetalleVent,
-- DetalleVenta.Descuento,DetalleVenta.total from detalleventa
-- inner join Producto on  producto.CodProducto = DetalleVenta.CodProducto 
-- order by DetalleVenta.CodVenta desc

-----
--go
--create procedure VentaHecha 
--as
--SELECT  dbo.Cliente.NombreCliente, dbo.Cliente.ApellidosCliente, dbo.Cliente.DniCLiente, dbo.Producto.NombreProducto, dbo.Producto.PrecioProducto, dbo.Venta.FechaVenta, dbo.Trabajador.NombreTrabajador, 
--                         dbo.DetalleVenta.CantidadDetalleVent, dbo.DetalleVenta.Descuento, dbo.DetalleVenta.total, dbo.Cliente.DireccionCliente
--FROM    dbo.Cliente INNER JOIN
--                         dbo.Venta ON dbo.Cliente.CodCliente = dbo.Venta.CodCliente INNER JOIN
--                         dbo.Trabajador ON dbo.Venta.CodTrabajador = dbo.Trabajador.CodTrabajador INNER JOIN
--                         dbo.DetalleVenta ON dbo.Venta.CodVenta = dbo.DetalleVenta.CodVenta INNER JOIN
--                         dbo.Producto ON dbo.DetalleVenta.CodProducto = dbo.Producto.CodProducto
--						 order by dbo.detalleVenta.codVenta desc
--go


use ferreterias
select *from trabajador 
select *from venta 
select *from detalleventa

------------------ VENTAS ----------
go
create proc CrearVenta
@CodVenta varchar (20),
@codTrab varchar (20),
@CodCliente varchar (20),
@Fecha datetime,
@TipoDoc varchar (30),
@NumDoc varchar (30)
as
insert into Venta
(CodVenta,CodTrabajador,CodCliente,FechaVenta,TipoDocumento,NumDocumento)
values (@CodVenta,@codTrab,@CodCliente,@Fecha,@TipoDoc,@NumDoc)
go

 exec CrearVenta 'V001','F01','A01','','Boleta','10101010'
 exec MostrarVenta

CREATE PROC EDITARVENTA
@CodVenta varchar (20),
@codTrab varchar (20),
@CodCliente varchar (20),
@Fecha datetime,
@TipoDoc varchar (30),
@NumDoc varchar (30)
AS
UPDATE Venta SET CodTrabajador=@codTrab ,CodCliente=@CodCliente,FechaVenta=@Fecha,TipoDocumento=@TipoDoc,NumDocumento=@NumDoc 
where CodVenta=@CodVenta 
go 


CREATE PROCEDURE ELIMINARVENTA
@CodVenta varchar (20)
AS 
DELETE FROM Venta WHERE CodVenta=@CodVenta
GO

GO
CREATE PROCEDURE MostrarVenta
AS
SELECT  dbo.Venta.CodVenta, dbo.Trabajador.CodTrabajador, dbo.Trabajador.NombreTrabajador, dbo.Venta.CodCliente, dbo.Cliente.NombreCliente, dbo.Cliente.ApellidosCliente, dbo.Venta.FechaVenta, dbo.Venta.TipoDocumento, 
                         dbo.Venta.NumDocumento
FROM            dbo.Venta INNER JOIN
                         dbo.Trabajador ON dbo.Venta.CodTrabajador = dbo.Trabajador.CodTrabajador INNER JOIN
                         dbo.Cliente ON dbo.Venta.CodCliente = dbo.Cliente.CodCliente
						 ORDER BY dbo.Venta.CodVenta 
						 GO

---------DETALLE DE VENTA--------------------------------------------------------
---------DETALLE DE VENTA--------------------------------------------------------
---------DETALLE DE VENTA--------------------------------------------------------
---------DETALLE DE VENTA--------------------------------------------------------
select * from detalleVenta

go
CREATE PROC INSERTARDVENTA

@CodV varchar (20),
@CodP varchar (20),
@Cantidad int 
AS INSERT INTO DetalleVenta (CodVenta,CodProducto,CantidadDetalleVent) 
VALUES (@CodV,@CodP,@Cantidad)
GO

CREATE PROC MostrarDetalleVenta2
as
SELECT       dbo.DetalleVenta.CodDetalleVenta  ,dbo.DetalleVenta.CodVenta, dbo.DetalleVenta.CodProducto, dbo.Producto.NombreProducto, dbo.DetalleVenta.CantidadDetalleVent, dbo.Producto.PrecioProducto, dbo.DetalleVenta.CantidadDetalleVent * dbo.Producto.PrecioProducto as Total
FROM            dbo.DetalleVenta INNER JOIN
                         dbo.Producto ON dbo.DetalleVenta.CodProducto = dbo.Producto.CodProducto
order by CodVenta
go 


----Stock ---
CREATE PROC AumentarStock
@Idprod varchar (20),
@Cantidadprod int
as
update Producto set StockProducto=StockProducto + @Cantidadprod   where CodProducto=@Idprod
go 
 
 exec DisminuirStock 'COD01',1
 select * from producto

CREATE PROC DisminuirStock
@Idprod varchar (20),
@Cantidadprod int
as
update Producto set StockProducto=StockProducto - @Cantidadprod   where CodProducto=@Idprod
go 

CREATE PROC DisminuirStock2
@Idprod varchar (20),
@Cantidadprod int
as
update Producto set StockProducto=StockProducto-@Cantidadprod   where CodProducto=@Idprod and StockProducto=@Cantidadprod 
go
-------------------------------
CREATE PROCEDURE BuscarVenta
@cod varchar (30)
AS
SELECT  dbo.Venta.CodVenta, dbo.Trabajador.CodTrabajador, dbo.Trabajador.NombreTrabajador, dbo.Venta.CodCliente, dbo.Cliente.NombreCliente, dbo.Cliente.ApellidosCliente, dbo.Venta.FechaVenta, dbo.Venta.TipoDocumento, 
                         dbo.Venta.NumDocumento
FROM            dbo.Venta INNER JOIN
                         dbo.Trabajador ON dbo.Venta.CodTrabajador = dbo.Trabajador.CodTrabajador INNER JOIN
                         dbo.Cliente ON dbo.Venta.CodCliente = dbo.Cliente.CodCliente
WHERE dbo.Venta.CodVenta  LIKE @cod+ '%' 

---------------------------------------------------- Generar comprobante

create proc generar_comprobante
@idventa varchar (20)
as 
SELECT        dbo.Venta.CodVenta, dbo.Cliente.NombreCliente, dbo.Cliente.ApellidosCliente, dbo.Cliente.DniCLiente, dbo.Producto.NombreProducto, dbo.Producto.PrecioProducto, dbo.DetalleVenta.CantidadDetalleVent, 
                         dbo.Producto.PrecioProducto * dbo.DetalleVenta.CantidadDetalleVent AS Total_Parcial, dbo.Trabajador.CodTrabajador, dbo.Trabajador.NombreTrabajador,dbo.Venta.FechaVenta, dbo.Venta.NumDocumento
FROM            dbo.Producto INNER JOIN
                         dbo.DetalleVenta ON dbo.Producto.CodProducto = dbo.DetalleVenta.CodProducto INNER JOIN
                         dbo.Venta ON dbo.DetalleVenta.CodVenta = dbo.Venta.CodVenta INNER JOIN
                         dbo.Cliente ON dbo.Venta.CodCliente = dbo.Cliente.CodCliente INNER JOIN
                         dbo.Trabajador ON dbo.Venta.CodTrabajador = dbo.Trabajador.CodTrabajador

					where	  dbo.Venta.CodVenta= @idventa































