USE Ferreterias
	--PRODUCTO
GO
SELECT* FROM Producto  

CREATE PROCEDURE MostrarProducto
AS
SELECT producto.CodProducto AS CodigoProducto
	,Categoria.NombreCategoria as NombreCategoria
	,producto.NombreProducto as NombreProducto
	,producto.PrecioProducto as Precio
	,producto.MarcaProducto as Marca
	,Producto.StockProducto 
	,Producto.StockMinimo
FROM Producto
INNER JOIN Categoria ON producto.CodCategoria = categoria.CodCategoria
ORDER BY producto.CodProducto DESC
GO

CREATE PROCEDURE Crearproducto
     @CodProd varchar (20)
	,@CodCat varchar (20)
    ,@NomProd VARCHAR(30)
	,@PrecioProd MONEY
	,@MarcaProd VARCHAR(30)
	,@StockProd INT
	,@StockMinimo INT
AS
INSERT INTO producto (
     CodProducto
    ,CodCategoria
	,NombreProducto
	,PrecioProducto
	,MarcaProducto
	,StockProducto
	,StockMinimo
	)
VALUES (
     @CodProd
    ,@CodCat
	,@NomProd
	,@PrecioProd
	,@MarcaProd
	,@StockProd
	,@StockMinimo
	)
GO

--nuevo insert
SELECT *FROM producto

SELECT *FROM Categoria
EXEC MostrarProducto

EXEC Crearproducto COD01,20, 'PINTURA AZUL',30,'ANIPSA',2,10
GO

CREATE PROCEDURE EditarProducto 
     @CodProd VARCHAR(20)
	,@NomProd VARCHAR(30)
	,@PrecioProd MONEY
	,@MarcaProd VARCHAR(30)
	,@StockProd INT
	,@StockMinimo INT
AS
UPDATE Producto
SET 
    NombreProducto = @NomProd
	,PrecioProducto = @PrecioProd
	,MarcaProducto = @MarcaProd
	,StockMinimo=@StockMinimo 
	,StockProducto=@StockProd 
WHERE CodProducto = @CodProd
GO

CREATE PROCEDURE EliminarPoducto
 @CodProd VARCHAR(20)
AS
DELETE
FROM producto
WHERE CodProducto = @CodProd
GO

exec EliminarPoducto 'CREMA'
go

select * from Producto
 ----------------------------------
 GO
CREATE PROCEDURE BuscarProducto
@Nombre varchar (30)
AS
SELECT producto.CodProducto AS CodigoProducto
	,Categoria.NombreCategoria as NombreCategoria
	,producto.NombreProducto as NombreProducto
	,producto.PrecioProducto as Precio
	,producto.MarcaProducto as Marca
	,Producto.StockProducto 
	,Producto.StockMinimo
FROM Producto
INNER JOIN Categoria ON producto.CodCategoria = categoria.CodCategoria
WHERE NombreProducto  LIKE @Nombre + '%'

exec BuscarProducto'PINTURA AZUL'

-------------------------------------------
--exec EditarProducto 'E01','10','Escalera 3 pasos',120,'Home collection',20,20
exec EditarProducto 'E01','Escalera 3 pasos',120,'Home collection',20,20