CREATE DATABASE UnMate

use UnMate

CREATE TABLE Perfil (
    ID_perfil INT PRIMARY KEY,
    Descripcion VARCHAR(30)
);

INSERT INTO Perfil (ID_perfil, Descripcion)
VALUES (1, 'Administrador'), (2, 'Vendedor'), (3, 'Supervisor');

CREATE TABLE Empleado (
	Cod_Empleado INT PRIMARY KEY IDENTITY(1,1),
    DNI VARCHAR (80),
    Nombre VARCHAR(200),
    Apellido VARCHAR(100),
    Email VARCHAR(100),
    Contraseña VARCHAR(120),
    Telefono VARCHAR(100),
    ID_perfil INT,
    Estado INT CHECK(Estado IN (0, 1)),
    CONSTRAINT FK_id_perfil FOREIGN KEY (ID_perfil) REFERENCES Perfil(ID_perfil)
);

CREATE TABLE Categoria(
		ID_Categoria int PRIMARY KEY,
		Descripcion varchar (20),
);

INSERT INTO Categoria(ID_Categoria,Descripcion) 
VALUES(1,'Madera'),(2,'Calabaza'),(3,'Caña'),(4,'Cuero')

CREATE TABLE Cliente (
	Cod_Cliente INT PRIMARY KEY IDENTITY(1,1),
    DNI_Cliente VARCHAR(80),
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Email VARCHAR(100),
    Telefono VARCHAR(100),
	Alta int,
    Estado INT CHECK(Estado IN (0, 1)),
);

CREATE TABLE TipoIva(
		IVA int PRIMARY KEY,
		Descripcion varchar(80)
);

INSERT INTO TipoIva (IVA,Descripcion)
VALUES (1,'Responsable Inscripto'),(2,'Responsable no Inscripto'),(3,'Consumidor Final')

CREATE TABLE Proveedor(
		Cod_Proveedor int PRIMARY KEY IDENTITY(1,1), 
		CUIT VARCHAR (80),
		Nombre varchar (100),
		Direccion varchar(160),
		Email varchar (100),
		Telefono varchar (100),
		IVA int,
		Estado int CHECK (Estado IN (0, 1)),
		CONSTRAINT FK_IVA FOREIGN KEY (IVA) REFERENCES TipoIva(IVA)
);

CREATE TABLE Producto(
		Cod_producto int PRIMARY KEY IDENTITY(1,1),
		Titulo varchar (400),
		Precio decimal (18, 2),
		Estado int CHECK (Estado IN (0, 1)),
		Stock int,
		Descripcion varchar(900),
		Color varchar (30) CHECK (Color IN ('Marron','Negro','Blanco','Gris')),
		ID_Categoria int,
		Cod_Proveedor int,
		Imagen varbinary(MAX),
		CONSTRAINT FK_ID_Categoria FOREIGN KEY (ID_Categoria) REFERENCES Categoria (ID_Categoria),
		CONSTRAINT FK_Proveedor FOREIGN KEY (Cod_Proveedor) REFERENCES Proveedor (Cod_Proveedor)
);
 
CREATE TABLE PedidoProveedor(
	Cod_Pedido int PRIMARY KEY IDENTITY(1,1),
	Descripcion varchar (600),
	Cantidad BIGINT,
	Cod_Producto int,
	Cod_Proveedor int,
	Fecha Date,
	Total DECIMAL(18, 2),
	Estado int CHECK (Estado IN (0, 1,2)) DEFAULT 1,
	CONSTRAINT FK_Cod_Producto FOREIGN KEY (Cod_Producto) REFERENCES Producto (Cod_Producto),
	CONSTRAINT FK_Cod_Proveedor FOREIGN KEY (Cod_Proveedor) REFERENCES Proveedor (Cod_Proveedor)
);

CREATE TABLE TipoPago(
	Cod_TipoPago int PRIMARY KEY,
	Descripcion varchar (100)
);

INSERT INTO TipoPago (Cod_TipoPago,Descripcion)
VALUES (1,'Mercado Pago'),(2,'Tarjeta de Credito')

CREATE TABLE Venta(
	Cod_Venta int PRIMARY KEY IDENTITY(1,1),
	Fecha date,
	Total decimal (10,2),
	Cod_Cliente int,
	Cod_Empleado int,
	Cod_TipoPago int,
	CONSTRAINT FK_Cod_Empleado_Venta FOREIGN KEY (Cod_Empleado) REFERENCES Empleado (Cod_Empleado),
	CONSTRAINT FK_Cod_Cliente_Venta FOREIGN KEY (Cod_Cliente) REFERENCES Cliente (Cod_Cliente),
	CONSTRAINT FK_Cod_Venta_TipoPago FOREIGN KEY (Cod_TipoPago) REFERENCES TipoPago (Cod_TipoPago)
);

CREATE TABLE DetalleVenta(
	Cod_Detalle int PRIMARY KEY IDENTITY (1,1),
	Cod_Producto int,
	Cod_Venta int,
	Precio decimal (10,2),
	Cantidad int,
	Total decimal (10,2),
	CONSTRAINT FK_Cod_Detalle_Producto_Venta FOREIGN KEY (Cod_Producto) REFERENCES Producto (Cod_Producto),
	CONSTRAINT FK_Cod_Venta FOREIGN KEY (Cod_Venta) REFERENCES Venta (Cod_Venta)
);


/* DATOS A INSERTAR */

/* EMPLEADOS */
INSERT INTO Empleado (DNI, Nombre, Apellido, Email, Contraseña, Telefono, ID_perfil, Estado)
VALUES ('1111', 'Admin', 'Admin', 'admin@example.com', '1234', '123456789', 1, 1);

INSERT INTO Empleado (DNI, Nombre, Apellido, Email, Contraseña, Telefono, ID_perfil, Estado)
VALUES ('2222', 'Vendedor', 'Vende', 'vendedor@example.com', '1234', '987654321', 2, 1);

INSERT INTO Empleado (DNI, Nombre, Apellido, Email, Contraseña, Telefono, ID_perfil, Estado)
VALUES ('3333', 'Supervisor', 'Super', 'supervisor@example.com', '1234', '555555555', 3, 1);

/* CLIENTES */
INSERT INTO Cliente (DNI_Cliente, Nombre, Apellido, Email, Telefono, Alta, Estado)
VALUES ('1111', 'Cliente1', 'Apellido1', 'cliente1@example.com', '111111', CONVERT(int, CONVERT(varchar, GETDATE(), 112)), 1);

INSERT INTO Cliente (DNI_Cliente, Nombre, Apellido, Email, Telefono, Alta, Estado)
VALUES ('2222', 'Cliente2', 'Apellido2', 'cliente2@example.com', '222222', CONVERT(int, CONVERT(varchar, GETDATE(), 112)), 1);

INSERT INTO Cliente (DNI_Cliente, Nombre, Apellido, Email, Telefono, Alta, Estado)
VALUES ('3333', 'Cliente3', 'Apellido3', 'cliente3@example.com', '333333', CONVERT(int, CONVERT(varchar, GETDATE(), 112)), 1);

/* PROVEEDORES */
INSERT INTO Proveedor (CUIT, Nombre, Direccion, Email, Telefono, IVA, Estado)
VALUES ('1111', 'Proveedor1', 'Dirección1', 'proveedor1@example.com', '111111', 1, 1);

INSERT INTO Proveedor (CUIT, Nombre, Direccion, Email, Telefono, IVA, Estado)
VALUES ('2222', 'Proveedor2', 'Dirección2', 'proveedor2@example.com', '22222', 2, 1);

INSERT INTO Proveedor (CUIT, Nombre, Direccion, Email, Telefono, IVA, Estado)
VALUES ('3333', 'Proveedor3', 'Dirección3', 'proveedor3@example.com', '33333', 3, 1);
