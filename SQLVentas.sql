use master
go


/*SE CREA LA BASE DE TADOS EN SUS RESPECTIVOS ARCHIVOS*/
CREATE DATABASE VENTACELULARES
ON PRIMARY(
	NAME=VENTACELULARES_DATA,
	FILENAME='E:\ventas\venta1.mdf',
	SIZE=25MB,
	MAXSIZE=30MB,
	FILEGROWTH=25%

)

LOG ON
(
	NAME=VENTACELULARES_LOG,
	FILENAME='E:\ventas\venta2.ldf',
	SIZE=15MB,
	MAXSIZE=25MB,
	FILEGROWTH=10%
)
GO
/*CREACION DE TABLAS DE MI PROYECTO*/
CREATE TABLE Proveedor
(
	Rut int NOT NULL PRIMARY KEY,
	RazonSocial varchar(50) NOT NULL,
	Telefono varchar(12) NOT NULL,
	Email varchar(100)NOT NULL,
	Direccion varchar(100) NOT NULL
)
GO
CREATE TABLE Categoria
(
	Idcat int NOT NULL PRIMARY KEY,
	Descripcion varchar(50) NOT NULL
)
GO
CREATE TABLE Producto
(
	Idpro int NOT NULL PRIMARY KEY,
	IdCategoria INT NOT NULL,
	RutProveedor INT NOT NULL,
	Nombre varchar(50) NOT NULL,
	Marca varchar(50) NOT NULL,
	Modelo varchar(59) NOT NULL,
	Stock int NOT NULL,
	PrecioCompra Decimal(6,2) NOT NULL,
	PrecioVenta Decimal(6,2) NOT NULL
)
GO
CREATE TABLE DetalleVenta
(
	Idet int identity PRIMARY KEY,
	IdProducto INT NOT NULL,
	IdVenta INT NOT NULL,
	Cantidad int NOT NULL
)
GO
CREATE TABLE Venta
(
	Idven int NOT NULL PRIMARY KEY,
	RutEmpleado int NOT NULL,
	NitCliente int NOT NULL,
	FechaVenta date NOT NULL,
	Descuento money,
	MontoTotal money NOT NULL
)
GO
CREATE TABLE Cliente
(
	Nit int NOT NULL PRIMARY KEY,
	Nombre2 varchar(50) NOT NULL,
	Apellido varchar(50) NOT NULL,
	Telefono varchar(12) NOT NULL,
	Direccion varchar(100) NOT NULL
)
GO
CREATE TABLE Reparacion
(
	Idrep int NOT NULL PRIMARY KEY,
	RutEmpleado INT NOT NULL,
	NitCliente INT NOT NULL,
	Marca varchar(50)NOT NULL,
	Modelo varchar(50) NOT NULL,
	Diagnostico varchar(100) NOT NULL,
	Cotizado money NOT NULL
)
GO
CREATE TABLE Empleado
(
	Rut int NOT NULL PRIMARY KEY,
	Nombre1 varchar(50) NOT NULL,
	Apellido varchar(50) NOT NULL,
	Telefono varchar(12) NOT NULL,
	Direccion varchar(100) NOT NULL,
	Cargo varchar(50)NOT NULL,
	Email varchar(50) NOT NULL,
	Contraseña varchar(50) NOT NULL,
	Sueldo money NOT NULL
)
GO



/*CLAVES FORANEAS DE MI BASE DE DATOS*/
ALTER TABLE Producto ADD CONSTRAINT FK_Producto_IdCategoria FOREIGN KEY(IdCategoria) REFERENCES Categoria(Idcat)
GO
ALTER TABLE Producto ADD CONSTRAINT FK_Producto_RutProveedor FOREIGN KEY(RutProveedor) REFERENCES Proveedor(Rut)
GO
ALTER TABLE DetalleVenta ADD CONSTRAINT FK_DetalleVenta_IdProducto FOREIGN KEY(IdProducto) REFERENCES Producto(Idpro)
GO
ALTER TABLE DetalleVenta ADD CONSTRAINT FK_DetalleVenta_IdVenta FOREIGN KEY(IdVenta) REFERENCES Venta(Idven)
GO
ALTER TABLE Venta ADD CONSTRAINT FK_Venta_NitCliente FOREIGN KEY(NitCliente) REFERENCES Cliente(Nit)
GO
ALTER TABLE Venta ADD CONSTRAINT FK_Venta_RutEmpleado FOREIGN KEY(RutEmpleado) REFERENCES Empleado(Rut)
GO
ALTER TABLE Reparacion ADD CONSTRAINT FK_Reparacion_NitCliente FOREIGN KEY(NitCliente) REFERENCES Cliente(Nit)
GO
ALTER TABLE Reparacion ADD CONSTRAINT FK_Reparacion_RutEmpleado FOREIGN KEY(RutEmpleado) REFERENCES Empleado(Rut)
GO
/*inserta datos a la categoria*/
INSERT INTO Categoria
VALUES (3,'Juguetes')
GO
SELECT *FROM Venta
GO

/*insertar datos a las tablas*/
insert into Empleado values (1,'Johnatan','Fernandez Selmon','75985771','AV.CLIOS45','ADMINISTRADOR','Roma@gmail.com','admin123',8000)
GO
SELECT *FROM Empleado
GO
/*LISTAR CATEGORIAS*/

/*meto del Loguin del usuario*/
create procedure LoguIniciarSesionUS 
@Usuario varchar(50),
@Password varchar(50)

as
SELECT *FROM Empleado
where Nombre1=@Usuario and Contraseña=@Password;
GO
/*RECUPERAR CONTRASEÑA DEL EMPLEADO*/
CREATE PROCEDURE RecuperarContraseña
@Nombre varchar(50)
AS
SELECT *FROM Empleado
WHERE Nombre1 LIKE @Nombre
GO
EXEC RecuperarContraseña 'Johnatan'
go

/*Mostrar productos*/
CREATE PROCEDURE MostrarProductos
as
select *from Producto
GO
exec MostrarProductos
Go
/*listar categorias*/
create procedure ListarCategorias 
as
Select *from Categoria order by Descripcion asc
go
exec ListarCategorias
GO
SELECT *FROM Proveedor
GO
SELECT *FROM Producto
GO
/*insertar categorias a la base de datos*/
CREATE PROCEDURE InsertarCategorias
@Id int,
@Descripcion varchar(50)
as
INSERT INTO Categoria values (@Id,@Descripcion)
GO
/*INSERTAR PRODUCTOS*/
CREATE PROCEDURE InsertaProductos
@Id int,
@IdCategoria int,
@RutProveedor int,
@Nombre varchar(50),
@Marca varchar(50),
@Modello varchar(50),
@Stock int,
@PrecioCompra Decimal(6,2),
@PrecioVenta Decimal(6,2)
as
INSERT INTO Producto values(@Id,@IdCategoria,@RutProveedor,@Nombre,@Marca,@Modello,@Stock,@PrecioCompra,@PrecioVenta)
GO
SELECT *FROM Empleado
GO
/*INSERTAR PROVEEDORES*/
CREATE PROCEDURE InsertarProveedores
@Rut int,
@RazonSocial varchar(50),
@Telefono varchar(50),
@Email varchar(50),
@Direccion varchar(50)
as
INSERT INTO Proveedor values(@Rut,@RazonSocial,@Telefono,@Email,@Direccion)
GO
exec InsertarProveedores 1,'Entel','75985771','entel@gmail.com','av. ayacucho1045'
select *from Proveedor
GO
/*insertar clientes a la base de datos*/
CREATE PROCEDURE InsertarClientes
@Nit int,
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(50),
@Direccion varchar(50)
as
INSERT INTO Cliente values(@Nit,@Nombre,@Apellido,@Telefono,@Direccion)
GO
exec InsertarClientes 678956212,'Julio','Arnez','75985771','AV.Blanco Galindo km9'
GO
SELECT *FROM Cliente
GO

/*INSERTAR EMPLEADOS a la base de datos*/
CREATE PROCEDURE InsertaEmpleado
@Rut int,
@Nombre varchar(50),
@Apellido varchar(50),
@Telfono varchar(12),
@Direccion varchar(100),
@Cargo varchar(50),
@Email varchar(50),
@Contraseña varchar(50),
@Sueldo  money
as
INSERT INTO Empleado values(@Rut,@Nombre,@Apellido,@Telfono,@Direccion,@Cargo,@Email,@Contraseña,@Sueldo)
GO
exec InsertaEmpleado 2,'Rillmar','Vasquez','75985567','Av.Colcapirhua km9','ADMINSTRADOR','Rillmar@gmail.com','Rill456',1000
GO
select *from Empleado
GO

/*cortar la tablas de proveedore en id y RazonSocial*/

CREATE PROCEDURE ListarEmpleado
as
SELECT Rut,Nombre1 FROM Empleado
GO
EXEC ListarEmpleado
GO
/*mostra los campos necesarios de la tabla proveedores*/

CREATE PROCEDURE ListaProveedor
AS
SELECT Rut,RazonSocial FROM Proveedor
GO
EXEC ListaProveedor
GO
/*LISTAR PRODUCTOS MEDIANTE UN PROCEDIMIENTO ALMACENADO*/
CREATE PROCEDURE ListarProductos
AS
SELECT Idpro AS ID,Descripcion AS Categoria,RazonSocial AS Proveedor,Nombre,Marca,Modelo,Stock,PrecioCompra,PrecioVenta
FROM Producto
Inner join Categoria ON Producto.IdCategoria=Categoria.Idcat
Inner join Proveedor ON Producto.RutProveedor=Proveedor.Rut
GO
exec ListarProductos
go
SELECT *FROM Producto
GO

/*PROCEDIMIENTO ALMACENADO PARA EDITAR PRODUCTO*/
CREATE PROCEDURE EditarProductos
@Id int,
@Nombre varchar(50),
@Marca varchar(50),
@Modelo varchar(50),
@Stock int,
@PreCom Decimal(6,2),
@PreVen Decimal(6,2)
AS
UPDATE Producto SET Idpro=@Id,Nombre=@Nombre,Marca=@Marca,Modelo=@Modelo,Stock=@Stock,PrecioCompra=@PreCom,PrecioVenta=@PreVen
where Idpro=@Id
GO
exec EditarProductos 2,'Celucash','Samsung','PRIMEJ8',4,'1500','1600'
GO
/*PROCEDIMIENTO ALMACENADO PARA EDITAR PROVEEDOR*/
CREATE PROCEDURE EditarProveedor
@Rut int,
@RazonSocial varchar(50),
@Telefono varchar(50),
@Email varchar(50),
@Direccion varchar(100)
AS
UPDATE Proveedor SET Rut=@Rut,RazonSocial=@RazonSocial,Telefono=@Telefono,Email=@Email,Direccion=@Direccion
where Rut=@Rut
GO
exec EditarProveedor 1,'Entel Bolivia','75985771','entel@gmail.com','av. ayacucho1045'
GO
SELECT *FROM Proveedor
GO
/*PROCEDIMIENTO ALMACENADO PARA EDITAR CLIENTE*/
CREATE PROCEDURE EditarCliente
@Nit int,
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(50),
@Direccion varchar(100)
AS
UPDATE Cliente SET Nit=@Nit,Nombre2=@Nombre,Apellido=@Apellido,Telefono=@Telefono,Direccion=@Direccion
WHERE Nit=@Nit
GO
/*PROCEDIMIENTO ALMACENADO PARA EDITAR EMPLEADO*/
CREATE PROCEDURE EditarEmpleado
@Rut int,
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(15),
@Direccion varchar(100),
@Cargo varchar(50),
@Email varchar(100),
@Password varchar(50),
@Sueldo money
AS
UPDATE Empleado SET Rut=@Rut,Nombre1=@Nombre,Apellido=@Apellido,Telefono=@Telefono,Direccion=@Direccion,Cargo=@Cargo,Email=@Email,Contraseña=@Password,Sueldo=@Sueldo
WHERE Rut=@Rut
GO

/*ELIMAR UN PRODUCTO DE LA LISTA*/
CREATE PROCEDURE EliminarProducto
@Id int
AS
DELETE FROM Producto WHERE @Id=Idpro
GO
EXEC EliminarProducto 8
GO
SELECT *FROM Empleado
GO
/*LISTAR EMPLEADOS MEDIANTE EL PROCEDIMIENTO ALMACENADO*/
CREATE PROCEDURE ListarEmpleados
AS
SELECT *FROM Empleado
GO

exec ListarEmpleados
GO
/*MOSTRAR CLIENTES*/
CREATE PROCEDURE MostrarClientes
AS
SELECT *FROM Cliente
GO
/*MOSTRAR PROVEEDORES*/
CREATE PROCEDURE MostraListaProveedores
AS
SELECT *FROM Proveedor
GO
exec MostraListaProveedores
GO
/*METODO DE BUSCAR CLIENTE*/
CREATE PROCEDURE BuscarCliente
@Filtro varchar(100)
AS
SELECT Nit,Nombre2,Apellido,Telefono,Direccion FROM Cliente
WHERE Nombre2 LIKE @Filtro +'%'
GO
/*METODO DE BUSCAR PRODUCTO*/
CREATE PROCEDURE BuscarProducto
@Filtro varchar(50)
AS
SELECT Idpro AS ID,Descripcion AS Categoria,RazonSocial AS Proveedor,Nombre,Marca,Modelo,Stock,PrecioCompra,PrecioVenta
FROM Producto
Inner join Categoria ON Producto.IdCategoria=Categoria.Idcat
Inner join Proveedor ON Producto.RutProveedor=Proveedor.Rut
 WHERE Nombre LIKE @Filtro +'%'
 GO
 /*METODO BUSCAR PROVEEDOR*/
 CREATE PROCEDURE BuscarProveedor
 @Filtro varchar(50)
 AS
 SELECT   Rut,RazonSocial,Telefono,Email,Direccion
 FROM Proveedor
 WHERE RazonSocial LIKE  @Filtro +'%'
 GO
 /*METODO BUSCAR EMPLEADO*/
 CREATE PROCEDURE BuscarEmpleado
 @Filtro varchar(50)
 AS
 SELECT Rut,Nombre1,Apellido,Telefono,Direccion,Cargo,Email,Contraseña,Sueldo
 FROM Empleado
 WHERE Nombre1 LIKE @Filtro +'%'
 GO
 /*METODO DE BUSCAR EL REGISTRO DE REPARACIONES*/
 CREATE PROCEDURE BuscarReparaciones
 @Filtro varchar(50)
 AS
 SELECT Idrep AS ID,Marca,Modelo,Diagnostico,Cotizado,Nombre2 AS Cliente,Nombre1 AS Tecnico
FROM Reparacion
Inner join Empleado ON Reparacion.RutEmpleado=Empleado.Rut
Inner join Cliente ON Reparacion.NitCliente=Cliente.Nit
WHERE Nombre2 LIKE @Filtro +'%'
GO

 /*METODO PARA REALIZAR REPARACION DE CELULAR QUE BUSCA CLIENTE*/
 CREATE PROCEDURE ClienteBuscado
 @Filtrar int
 AS
 SELECT Apellido
 FROM Cliente
 WHERE Nit LIKE @Filtrar 
 GO
 /*METODO QUE BUSCA CLIENTE POR NIT Y DEVUELVE APELLIDO Y NOMBRE*/
 CREATE PROCEDURE ClientesBuscados
 @Filtrar int
 AS
 SELECT Apellido,Nombre2
 FROM Cliente
 WHERE Nit LIKE @Filtrar
 GO
 /*METODO QUE BUSCA PRODUCTO POR ID Y DEVUELVE LOS CAMPOS NECESARIOS*/
 CREATE PROCEDURE ProductosBuscados
 @Filtrar int
 AS
 SELECT Nombre,Marca,Modelo,PrecioVenta,Stock
 FROM Producto
 WHERE Idpro LIKE @Filtrar
 GO

/*METO PARA REGISTRAR UNA RECEPCION UNA REPARACION DE CELULAR*/
CREATE PROCEDURE InsertarCelularMantenimiento
@Idrep int,
@RutEmp int,
@NitCli int,
@Marca varchar(50),
@Modelo varchar(50),
@Diag varchar(200),
@Cotizacion money
AS
INSERT INTO Reparacion values(@Idrep,@RutEmp,@NitCli,@Marca,@Modelo,@Diag,@Cotizacion)
GO
/*LISTAR EMPLEADOS SOLO CON CARGO TECNICO*/
CREATE PROCEDURE ListarTecnicos
AS
SELECT Rut,Nombre1
FROM Empleado
WHERE Cargo='TECNICO'
GO
/*MOSTRAR LISTA DE REPARACIONES REALIZADAS*/
CREATE PROCEDURE ListarReparacionCelulares
AS
SELECT Idrep AS ID,Marca,Modelo,Diagnostico,Cotizado,Nombre2 AS Cliente,Nombre1 AS Tecnico
FROM Reparacion
Inner join Empleado ON Reparacion.RutEmpleado=Empleado.Rut
Inner join Cliente ON Reparacion.NitCliente=Cliente.Nit
GO
/*generrar idventa*/

INSERT INTO Venta VALUES(1,1,678956212,'2/3/2018',2,50)
select *from Venta
GO
/*AGREGAR DETALLE DE VENTA*/
CREATE PROCEDURE InsertarDetalleVenta
@IdPro int,
@IdVenta int,
@Cantidad int
AS
INSERT INTO DetalleVenta VALUES(@IdPro,@IdVenta,@Cantidad)
GO
select *from DetalleVenta
go
/*generar id venta */
CREATE PROCEDURE GIdVentas
@id int out
AS BEGIN
IF(Not Exists(SELECT Idven FROM Venta ))
	set @id=1
else begin
	Set @id=(Select Max(Idven)+1 FROM Venta)
	end
end
GO
select *from Venta
select *from DetalleVenta
go
/*procedimientos de datos estadisticos*/
CREATE PROCEDURE DatosEstadisticos
@totalventa money out,
@nProd int out,
@nemple int out,
@nCli int out,
@nProvee int out,
@nCat int out
as
SET @totalventa= (SELECT SUM(MontoTotal)AS Total FROM Venta) 
SET @nProd= (SELECT COUNT(Idpro)AS CanProducto FROM Producto)
SET @nemple= (SELECT COUNT(Rut) AS CanEmpleados FROM Empleado)
SET @nCli=(SELECT COUNT(Nit) AS CanClientes FROM Cliente)
SET @nProvee=(SELECT COUNT(Rut) AS CanProveedores FROM proveedor)
SET @nCat=(SELECT COUNT(Idcat) AS CanCategorias FROM Categoria)
GO
----PRODUCTOS PREFERIDOS POR EL PUBLICO-----------
