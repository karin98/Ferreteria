USE Ferreterias

select *from Categoria 
--Categoria
CREATE PROCEDURE MostrarCat
AS
SELECT CodCategoria
	,NombreCategoria
	
FROM Categoria
ORDER BY CodCategoria DESC
GO

EXEC MostrarCat


---------------------------

CREATE PROCEDURE CrearCat
     @CodigoCat varchar (20),
     @NombreCat VARCHAR(30)
	
AS
INSERT INTO Categoria (
     CodCategoria,
	NombreCategoria
	)
VALUES (
    @CodigoCat,
	@NombreCat
	)
GO

exec CrearCat 10,'Tornilleria'
go

select * from Categoria
--------------------------
CREATE PROCEDURE EditarCat 
     @CodCat varchar (20)
	,@NombreCat VARCHAR(30)
AS
UPDATE Categoria
SET CodCategoria=@CodCat, NombreCategoria = @NombreCat
WHERE CodCategoria = @CodCat
GO

-------------------------------
CREATE PROCEDURE EliminarCat @CodCat varchar (20)
AS
DELETE
FROM Categoria
WHERE CodCategoria = @CodCat
GO

------------------------------

CREATE PROCEDURE BuscarCat 
@NombreCat varchar (30)
AS
SELECT CodCategoria,NombreCategoria  from Categoria
WHERE NombreCategoria LIKE @NombreCat + '%'

exec BuscarCat 'tornilleria'