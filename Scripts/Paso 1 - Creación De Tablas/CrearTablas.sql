/* Se crean las entidades del sistema en función del DER realizado */

/* TODO: Agregar tablas de Usuario, Rol, Funcionalidad, Funcionalidad_Por_Rol */

CREATE TABLE Sucursal (
	id_sucursal INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	domicilio NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(255) NOT NULL UNIQUE,
	habilitada BIT NOT NULL
)

/* Agregar tabla de Rol_De_Usuario_Por_Sucursal */

CREATE TABLE ClienteParalitico (
	id_cliente INT IDENTITY(1, 1) PRIMARY KEY,
	dni NUMERIC(18,0) NOT NULL UNIQUE,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	nacimiento DATETIME NOT NULL,
	mail NVARCHAR(255) NOT NULL, 
	domicilio NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(255) NOT NULL,
	telefono INT,
)

CREATE TABLE Cliente (
	id_cliente INT IDENTITY(1, 1) PRIMARY KEY,
	dni NUMERIC(18,0) NOT NULL UNIQUE,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	nacimiento DATETIME NOT NULL,
	mail NVARCHAR(255) NOT NULL, 
	domicilio NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(255) NOT NULL,
	telefono INT,
	habilitado BIT NOT NULL
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
	dia_rendicion INT NOT NULL,
	habilitada BIT NOT NULL,
	id_rubro INT FOREIGN KEY REFERENCES Rubro(id_rubro) NOT NULL
)

CREATE TABLE Rendicion (
	numero_rendicion INT PRIMARY KEY,
	importe_comision NUMERIC(18,2) NOT NULL,
	fecha DATETIME NOT NULL,
)

CREATE TABLE Factura (
	numero_factura INT PRIMARY KEY,
	factura_monto_total NUMERIC(18, 2) NOT NULL,
	factura_fecha_alta DATETIME NOT NULL,
	factura_fecha_vencimiento DATETIME NOT NULL,
	factura_habilitada BIT NOT NULL,
	id_cliente INT FOREIGN KEY REFERENCES Cliente(id_cliente) NOT NULL,
	id_empresa INT FOREIGN KEY REFERENCES Empresa(id_empresa) NOT NULL,
	numero_rendicion INT FOREIGN KEY REFERENCES Rendicion(numero_rendicion),
)

CREATE TABLE Item (
	id_item INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	monto NUMERIC(18, 2) NOT NULL,
	cantidad INT NOT NULL,
	numero_factura INT FOREIGN KEY REFERENCES Factura(numero_factura),
)

CREATE TABLE Devolucion (
	id_devolucion INT IDENTITY(1, 1) PRIMARY KEY,
	fecha_devolucion DATETIME NOT NULL,
);

CREATE TABLE Medio_De_Pago (
	id_medio_de_pago INT IDENTITY(1, 1) PRIMARY KEY,
	descripcion nvarchar(50) NOT NULL,
); 

CREATE TABLE Pago (
	numero_pago INT PRIMARY KEY ,
	monto_total NUMERIC(18,2) NOT NULL,
	fecha_pago DATETIME NOT NULL,
	numero_factura INT FOREIGN KEY REFERENCES Factura(numero_factura) NOT NULL,
	id_medio_de_pago INT FOREIGN KEY REFERENCES Medio_De_Pago(id_medio_de_pago) NOT NULL,
	id_cliente INT FOREIGN KEY REFERENCES Cliente(id_cliente) NOT NULL,
	id_sucursal INT FOREIGN KEY REFERENCES Sucursal(id_sucursal) NOT NULL,
);

CREATE TABLE Item_Pago (
	id_item INT FOREIGN KEY REFERENCES Item(id_item) NOT NULL,
	numero_pago INT FOREIGN KEY REFERENCES Pago(numero_pago) NOT NULL,
	CONSTRAINT id_item_pago PRIMARY KEY(id_item, numero_pago)
);

CREATE TABLE Item_Rendicion (
	id_item INT FOREIGN KEY REFERENCES Item(id_item) NOT NULL,
	numero_rendicion INT FOREIGN KEY REFERENCES Rendicion(numero_rendicion) NOT NULL,
	CONSTRAINT id_item_rendicion PRIMARY KEY(id_item, numero_rendicion)
);