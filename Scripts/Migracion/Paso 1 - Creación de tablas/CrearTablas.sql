/* Se crean las entidades del sistema en función del DER realizado */

CREATE TABLE Funcionalidad (
	id_funcionalidad INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL
)

CREATE TABLE Rol (
	id_rol INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	estado BIT NOT NULL
)

CREATE TABLE Funcionalidad_Por_Rol (
	id_funcionalidad INT FOREIGN KEY REFERENCES Funcionalidad(id_funcionalidad) NOT NULL,
	id_rol INT FOREIGN KEY REFERENCES Rol(id_rol) NOT NULL,
	CONSTRAINT id_funcionalidad_por_rol PRIMARY KEY(id_funcionalidad, id_rol)
)

CREATE TABLE Usuario (
	id_usuario INT IDENTITY(1, 1) PRIMARY KEY,
	username NVARCHAR(255) NOT NULL,
	contraseña NVARCHAR(255) NOT NULL,
	estado BIT NOT NULL
)

CREATE TABLE Sucursal (
	id_sucursal INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	domicilio NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(255) NOT NULL UNIQUE,
	estado BIT NOT NULL
)

CREATE TABLE Rol_De_Usuario_Por_Sucursal (
	id_usuario INT FOREIGN KEY REFERENCES Usuario(id_usuario) NOT NULL,
	id_rol INT FOREIGN KEY REFERENCES Rol(id_rol) NOT NULL,
	id_sucursal INT FOREIGN KEY REFERENCES Sucursal(id_sucursal) NOT NULL,
	CONSTRAINT id_rol_de_usuario_por_sucursal PRIMARY KEY(id_usuario, id_rol, id_sucursal)
)

CREATE TABLE ClienteParalitico (
	id_cliente INT IDENTITY(1, 1) PRIMARY KEY,
	dni NUMERIC(18,0) NOT NULL UNIQUE,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	nacimiento DATETIME NOT NULL,
	mail NVARCHAR(255) NOT NULL, 
	domicilio NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(255) NOT NULL,
)

CREATE TABLE Cliente (
	id_cliente INT IDENTITY(1, 1) PRIMARY KEY,
	dni NUMERIC(18,0) NOT NULL UNIQUE,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	nacimiento DATETIME NOT NULL,
	mail NVARCHAR(255) NOT NULL UNIQUE, 
	domicilio NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(255) NOT NULL,
	telefono INT,
	estado BIT NOT NULL
)

CREATE TABLE Rubro (
	id_rubro INT IDENTITY(1, 1) PRIMARY KEY,
	descripcion NVARCHAR(50) NOT NULL 
)

CREATE TABLE Empresa (
	id_empresa INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	cuit NVARCHAR(50) NOT NULL UNIQUE,
	domicilio NVARCHAR(255) NOT NULL,
	dia_rendicion INT,
	estado BIT NOT NULL,
	id_rubro INT FOREIGN KEY REFERENCES Rubro(id_rubro) NOT NULL
)

CREATE TABLE Rendicion (
	numero_rendicion INT IDENTITY(1, 1) PRIMARY KEY,
	importe_comision NUMERIC(18,2) NOT NULL,
	fecha_rendicion DATETIME NOT NULL
)

CREATE TABLE Factura (
	numero_factura INT PRIMARY KEY,
	factura_monto_total NUMERIC(18, 2) NOT NULL,
	factura_fecha_alta DATETIME NOT NULL,
	factura_fecha_vencimiento DATETIME NOT NULL,
	id_cliente INT FOREIGN KEY REFERENCES Cliente(id_cliente) NOT NULL,
	id_empresa INT FOREIGN KEY REFERENCES Empresa(id_empresa) NOT NULL,
	numero_rendicion INT FOREIGN KEY REFERENCES Rendicion(numero_rendicion)
)

CREATE TABLE Item (
	id_item INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	monto NUMERIC(18, 2) NOT NULL,
	cantidad INT NOT NULL,
	numero_factura INT FOREIGN KEY REFERENCES Factura(numero_factura) NOT NULL
)

CREATE TABLE Devolucion (
	id_devolucion INT IDENTITY(1, 1) PRIMARY KEY,
	fecha_devolucion DATETIME NOT NULL,
	motivo NVARCHAR(255) NOT NULL,
	numero_factura INT FOREIGN KEY REFERENCES Factura(numero_factura)
)

CREATE TABLE Medio_De_Pago (
	id_medio_de_pago INT IDENTITY(1, 1) PRIMARY KEY,
	descripcion nvarchar(50) NOT NULL
)

CREATE TABLE Pago (
	numero_pago INT IDENTITY(1, 1) PRIMARY KEY,
	monto_total NUMERIC(18,2) NOT NULL,
	fecha_pago DATETIME NOT NULL,
	id_medio_de_pago INT FOREIGN KEY REFERENCES Medio_De_Pago(id_medio_de_pago) NOT NULL,
	id_cliente INT FOREIGN KEY REFERENCES Cliente(id_cliente) NOT NULL,
	id_sucursal INT FOREIGN KEY REFERENCES Sucursal(id_sucursal) NOT NULL,
	id_rendicion INT FOREIGN KEY REFERENCES Rendicion(numero_rendicion),
	id_factura INT FOREIGN KEY REFERENCES Factura(numero_factura) NOT NULL
)

CREATE TABLE Item_Pago (
	id_item INT FOREIGN KEY REFERENCES Item(id_item) NOT NULL,
	numero_factura INT FOREIGN KEY REFERENCES Factura(numero_factura) NOT NULL,
	numero_pago INT FOREIGN KEY REFERENCES Pago(numero_pago) NOT NULL,
	CONSTRAINT id_item_pago PRIMARY KEY(id_item, numero_factura, numero_pago)
)

CREATE TABLE Item_Rendicion (
	id_item INT FOREIGN KEY REFERENCES Item(id_item) NOT NULL,
	numero_rendicion INT FOREIGN KEY REFERENCES Rendicion(numero_rendicion) NOT NULL,
	CONSTRAINT id_item_rendicion PRIMARY KEY(id_item, numero_rendicion)
)