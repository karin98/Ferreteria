create database Ferreterias

use Ferreterias



--CONSTRAINT fk1 FOREIGN KEY(Id_cliente)
--REFERENCES dbo.Cliente (Id_cliente)
--)

 create table Producto
(CodProducto varchar (20)primary key,
CodCategoria varchar (20)  ,
NombreProducto varchar(30) null,
PrecioProducto money null,
MarcaProducto varchar (30) null,
StockProducto int null,
StockMinimo int null ,
constraint fk1 foreign key (CodCategoria)
references Categoria(CodCategoria)
)

create table Categoria
(CodCategoria varchar(20) primary key ,
NombreCategoria varchar (30) null)

create table Trabajador
(CodTrabajador varchar (20) primary key  ,
NombreTrabajador varchar (30) null,
ApellidoTrabajador varchar (30) null,
DireccionTrabajador varchar (30) null,
CelTrabajador varchar (10) null,
DniTrabajador int unique null,
EmailTrabajador varchar (30) null,
cargoTrabajador  varchar (30) null,
UsuTrabajador  varchar (30) unique null,
PassTrabajador varchar (30) null,
TipoUsuTrabajador varchar (30)null
)

create table Cliente 
(CodCliente varchar (20) primary key,
NombreCliente varchar (30) null,
ApellidosCliente varchar (30) null,
DireccionCliente varchar (30) null,
CelCliente varchar (30) null,
DniCLiente varchar (30) null)


create table Venta (
CodVenta varchar (20) primary key ,
CodTrabajador varchar (20) ,
CodCliente varchar (20),
FechaVenta datetime ,
constraint fk2 foreign key (CodTrabajador)
references Trabajador(CodTrabajador),
constraint fk3 foreign key (CodCliente)
references Cliente(CodCliente)
)

alter table Venta add  TipoDocumento varchar(30)
alter table Venta add  NumDocumento varchar(30)


--CONSTRAINT fk1 FOREIGN KEY(Id_cliente)
--REFERENCES dbo.Cliente (Id_cliente)
--)

create table DetalleVenta(
CodDetalleVenta int identity primary key  ,
CodVenta varchar (20) ,
CodProducto varchar (20),
CantidadDetalleVent int,
constraint fk4 foreign key (CodVenta)
references Venta(CodVenta),
constraint  fk5 foreign key (CodProducto)
references Producto(CodProducto)
)

--alter table DetalleVenta 
--drop column total





