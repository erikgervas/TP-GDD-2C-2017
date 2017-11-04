/* Se crean las entidades del sistema en función del DER realizado */

CREATE TABLE SQL_BOYS.Funcionalidad (
	id_funcionalidad INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL
)

CREATE TABLE SQL_BOYS.Rol (
	id_rol INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	habilitadx BIT NOT NULL
)

CREATE TABLE SQL_BOYS.Funcionalidad_Por_Rol (
	id_funcionalidad INT FOREIGN KEY REFERENCES SQL_BOYS.Funcionalidad(id_funcionalidad) NOT NULL,
	id_rol INT FOREIGN KEY REFERENCES SQL_BOYS.Rol(id_rol) NOT NULL,
	CONSTRAINT id_funcionalidad_por_rol PRIMARY KEY(id_funcionalidad, id_rol)
)

CREATE TABLE SQL_BOYS.Usuario (
	id_usuario INT IDENTITY(1, 1) PRIMARY KEY,
	username NVARCHAR(255) UNIQUE NOT NULL,
	contraseña NVARCHAR(255) NOT NULL,
	habilitadx BIT NOT NULL
)

CREATE TABLE SQL_BOYS.Sucursal (
	cp_sucursal NUMERIC(18, 0) PRIMARY KEY,
	nombre NVARCHAR(50) NOT NULL,
	domicilio NVARCHAR(50) NOT NULL,
	habilitadx BIT NOT NULL
)

CREATE TABLE SQL_BOYS.Rol_De_Usuario_Por_Sucursal (
	id_rol INT FOREIGN KEY REFERENCES SQL_BOYS.Rol(id_rol) NOT NULL,
	id_usuario INT FOREIGN KEY REFERENCES SQL_BOYS.Usuario(id_usuario) NOT NULL,
	cp_sucursal NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Sucursal(cp_sucursal) NOT NULL,
	CONSTRAINT id_rol_de_usuario_por_sucursal PRIMARY KEY(id_rol, id_usuario, cp_sucursal)
)

CREATE TABLE SQL_BOYS.Cliente (
	dni_cliente NUMERIC(18,0) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	nacimiento DATETIME NOT NULL,
	mail NVARCHAR(255) NOT NULL UNIQUE, 
	domicilio NVARCHAR(255) NOT NULL,
	codigo_postal NVARCHAR(255) NOT NULL,
	telefono INT NOT NULL,
	habilitadx BIT NOT NULL
)

CREATE TABLE SQL_BOYS.Rubro (
	id_rubro NUMERIC(18,0) IDENTITY(1, 1) PRIMARY KEY,
	descripcion NVARCHAR(50) NOT NULL 
)

CREATE TABLE SQL_BOYS.Empresa (
	id_empresa INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	cuit NVARCHAR(50) NOT NULL UNIQUE,
	domicilio NVARCHAR(255) NOT NULL,
	dia_rendicion INT NOT NULL CHECK (dia_rendicion BETWEEN 1 AND 28),
	porcentaje_comision INT NOT NULL CHECK (porcentaje_comision BETWEEN 1 AND 100),
	habilitadx BIT NOT NULL,
	id_rubro NUMERIC(18,0) FOREIGN KEY REFERENCES SQL_BOYS.Rubro(id_rubro) NOT NULL
)

CREATE TABLE SQL_BOYS.Rendicion (
	numero_rendicion NUMERIC(18, 0) IDENTITY(1, 1) PRIMARY KEY,
	importe_comision NUMERIC(18,2) NOT NULL,
	fecha_rendicion DATETIME NOT NULL
)

CREATE TABLE SQL_BOYS.Factura (
	numero_factura NUMERIC(18, 0) PRIMARY KEY,
	factura_monto_total NUMERIC(18, 2) NOT NULL,
	factura_fecha_alta DATETIME NOT NULL,
	factura_fecha_vencimiento DATETIME NOT NULL,
	dni_cliente NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Cliente(dni_cliente) NOT NULL,
	id_empresa INT FOREIGN KEY REFERENCES SQL_BOYS.Empresa(id_empresa) NOT NULL,
	numero_rendicion NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Rendicion(numero_rendicion)
)

CREATE TABLE SQL_BOYS.Devolucion (
	id_devolucion INT IDENTITY(1, 1) PRIMARY KEY,
	fecha_devolucion DATETIME NOT NULL,
	motivo NVARCHAR(255) NOT NULL,
	numero_factura NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Factura(numero_factura)
)

CREATE TABLE SQL_BOYS.Medio_De_Pago (
	id_medio_de_pago INT IDENTITY(1, 1) PRIMARY KEY,
	descripcion nvarchar(50) NOT NULL
)

CREATE TABLE SQL_BOYS.Pago (
	numero_pago NUMERIC(18, 0) IDENTITY(1, 1) PRIMARY KEY,
	monto_total NUMERIC(18,2) NOT NULL,
	fecha_pago DATETIME NOT NULL,
	id_medio_de_pago INT FOREIGN KEY REFERENCES SQL_BOYS.Medio_De_Pago(id_medio_de_pago) NOT NULL,
	dni_cliente NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Cliente(dni_cliente) NOT NULL,
	cp_sucursal NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Sucursal(cp_sucursal) NOT NULL
)

CREATE TABLE SQL_BOYS.Item (
	id_item INT IDENTITY(1, 1) PRIMARY KEY,
	nombre NVARCHAR(255) NOT NULL,
	monto NUMERIC(18, 2) NOT NULL,
	cantidad INT NOT NULL,
	numero_factura NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Factura(numero_factura) NOT NULL
)

CREATE TABLE SQL_BOYS.Item_Pago (
	id_item INT FOREIGN KEY REFERENCES SQL_BOYS.Item(id_item) NOT NULL,
	numero_factura NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Factura(numero_factura) NOT NULL,
	numero_pago NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Pago(numero_pago) NOT NULL,
	CONSTRAINT id_item_pago PRIMARY KEY(id_item, numero_factura, numero_pago)
)

CREATE TABLE SQL_BOYS.Item_Rendicion (
	id_item INT FOREIGN KEY REFERENCES SQL_BOYS.Item(id_item) NOT NULL,
	numero_rendicion NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Rendicion(numero_rendicion) NOT NULL,
	CONSTRAINT id_item_rendicion PRIMARY KEY(id_item, numero_rendicion)
)

GO

/* Se crean vistas auxiliares para mejorar la performance de la migración, sobretodo cuando es necesario consultar a la tabla maestra más de una vez cuando el resultado de una consulta ya tiene todo lo necesario. */

/* Vista de todos los clientes del sistema, para optimizar la búsqueda de clientes con el mismo mail. */

CREATE VIEW SQL_BOYS.View_Cliente AS

	SELECT DISTINCT

		[Cliente-Dni] AS view_dni_cliente,
		[Cliente-Apellido] AS view_apellido,
		[Cliente-Nombre] AS view_nombre,
		[Cliente-Fecha_Nac] AS view_nacimiento,
		Cliente_Mail AS view_mail,
		Cliente_Direccion AS view_domicilio,
		Cliente_Codigo_Postal AS view_codigo_postal

	FROM [GD2C2017].[gd_esquema].[Maestra]

GO

/* Hay clientes con el mismo mail, que impiden cumplir con el requerimiento de mails únicos. Esto optimiza el tiempo de búsqueda de los mismos usando la vista anterior. */

CREATE VIEW SQL_BOYS.View_Cliente_Conflictivo AS

	SELECT

		c1.view_dni_cliente AS view_dni_cliente,
		c1.view_apellido AS view_apellido,
		c1.view_nombre AS view_nombre,
		c1.view_nacimiento AS view_nacimiento,
		c1.view_mail AS view_mail,
		c1.view_domicilio AS view_domicilio,
		c1.view_codigo_postal AS view_codigo_postal

	FROM SQL_BOYS.View_Cliente c1, SQL_BOYS.View_Cliente c2
	
	WHERE c1.view_dni_cliente != c2.view_dni_cliente AND c1.view_mail = c2.view_mail

GO

/* Vista para no recorrer toda la tabla maestra de nuevo sólo para buscar el rubro de una empresa. */

CREATE VIEW SQL_BOYS.View_Empresa_Rubro AS

	SELECT DISTINCT

		[Empresa_Nombre] AS view_nombre,
		[Empresa_Cuit] AS view_cuit,
		[Empresa_Direccion] AS view_domicilio,
		[Empresa_Rubro] AS view_id_rubro,
		[Rubro_Descripcion] AS view_descripcion

	FROM [GD2C2017].[gd_esquema].[Maestra]

GO

/* Vista para no tener que recorrer la tabla maestra de nuevo para buscar facturas. */

CREATE VIEW SQL_BOYS.View_Factura AS

	SELECT DISTINCT
		
		[Nro_Factura] AS view_numero_factura,
		[Factura_Total] AS view_factura_monto_total,
		[Factura_Fecha] AS view_factura_fecha_alta,
		[Factura_Fecha_Vencimiento] AS view_factura_fecha_vencimiento,
		[Cliente-Dni] AS view_dni_cliente,
		[Empresa_Cuit] AS view_cuit_empresa,
		[Rendicion_Nro] AS view_numero_rendicion

	FROM [GD2C2017].[gd_esquema].[Maestra] m

GO

/* Vista para obtener las facturas con sus rendiciones, ya que en el anterior no se añadieron. */

CREATE VIEW SQL_BOYS.View_Factura_Con_Rendicion AS

	SELECT

		v1.view_numero_factura AS view_numero_factura,
		v1.view_factura_monto_total AS view_factura_monto_total,
		v1.view_factura_fecha_alta AS view_factura_fecha_alta,
		v1.view_factura_fecha_vencimiento AS view_factura_fecha_vencimiento,
		v1.view_dni_cliente AS view_dni_cliente,
		v1.view_cuit_empresa AS view_cuit_empresa,
		v1.view_numero_rendicion AS view_numero_rendicion
		
	FROM SQL_BOYS.View_Factura v1
		
	WHERE v1.view_numero_rendicion IS NOT NULL

	UNION

	SELECT
	
		v2.view_numero_factura AS view_numero_factura,
		v2.view_factura_monto_total AS view_factura_monto_total,
		v2.view_factura_fecha_alta AS view_factura_fecha_alta,
		v2.view_factura_fecha_vencimiento AS view_factura_fecha_vencimiento,
		v2.view_dni_cliente AS view_dni_cliente,
		v2.view_cuit_empresa AS view_cuit_empresa,
		v2.view_numero_rendicion AS view_numero_rendicion
		
	FROM SQL_BOYS.View_Factura v2
	
	WHERE NOT EXISTS (SELECT 1 FROM SQL_BOYS.View_Factura v1 WHERE v2.view_numero_factura = v1.view_numero_factura AND v1.view_numero_rendicion IS NOT NULL)

GO

/* Vista para no tener que recorrer la tabla otra vez para obtener los medios de pago o los pagos. */

CREATE VIEW SQL_BOYS.View_Pago_Medio_De_Pago AS

	SELECT DISTINCT 
		
		[Pago_nro] AS view_numero_pago,
		[Total] AS view_monto_total,
		[Pago_Fecha] AS view_fecha_pago,
		[FormaPagoDescripcion] AS view_medio_de_pago,
		[Cliente-Dni] AS view_dni_cliente,
		[Sucursal_Codigo_Postal] AS view_cp_sucursal

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE [Pago_nro] IS NOT NULL

GO

/* Vista para no tener que recorrer la tabla otra vez para obtener los items y sus variantes. */

CREATE VIEW SQL_BOYS.View_Item AS

	SELECT DISTINCT

		m.[ItemFactura_Monto] AS view_monto,
		m.[ItemFactura_Cantidad] AS view_cantidad,
		m.[Nro_Factura] AS view_numero_factura,
		m.[ItemPago_nro] AS view_numero_pago,
		m.[ItemRendicion_nro] AS view_numero_rendicion

	FROM [GD2C2017].[gd_esquema].[Maestra] m

GO

/* Como los clientes conflictivos también tienen facturas, pagos y rendiciones, decidimos apartar las filas de la tabla maestra de dichos clientes. */

CREATE VIEW SQL_BOYS.View_Tabla_Maestra_Conflictiva AS

	SELECT

		[Cliente-Dni],
		[Cliente-Apellido],
		[Cliente-Nombre],
		[Cliente-Fecha_Nac],
		[Cliente_Mail],
		[Cliente_Direccion],
		[Cliente_Codigo_Postal],
		[Nro_Factura],
		[Factura_Fecha],
		[Factura_Total],
		[Factura_Fecha_Vencimiento],
		[ItemFactura_Monto],
		[ItemFactura_Cantidad],
		[Empresa_Nombre],
		[Empresa_Cuit],
		[Empresa_Direccion],
		[Empresa_Rubro],
		[Rubro_Descripcion],
		[Pago_nro],
		[Pago_Fecha],
		[ItemPago_nro],
		[Total],
		[FormaPagoDescripcion],
		[Sucursal_Nombre],
		[Sucursal_Dirección],
		[Sucursal_Codigo_Postal],
		[Rendicion_Nro],
		[Rendicion_Fecha],
		[ItemRendicion_nro],
		[ItemRendicion_Importe]

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE EXISTS (SELECT 1 FROM SQL_BOYS.View_Cliente_Conflictivo WHERE view_dni_cliente = [Cliente-Dni])

GO

/* Populamos las tablas con los datos de la tabla maestra. */

INSERT INTO SQL_BOYS.Funcionalidad (nombre)

	VALUES
		
		('Gestionar clientes'),
		('Gestionar empresas'),
		('Gestionar sucursales'),
		('Gestionar facturas'),
		('Cobrar facturas'),
		('Rendir facturas'),
		('Devolver facturas')

INSERT INTO SQL_BOYS.Rol (nombre, habilitadx)
	
	VALUES
		
		('Cobrador', 1),
		('Administrador', 1),
		('Ajustador de cuentas', 0)

INSERT INTO SQL_BOYS.Funcionalidad_Por_Rol (id_funcionalidad, id_rol)

	VALUES
		
		(1 , 1) , (2 , 1) , (3 , 1) , (4 , 1) , (5 , 1) ,
		(1 , 2) , (2 , 2) , (3 , 2) , (4 , 2) , (5 , 2) , (6 , 2) , (7 , 2)

INSERT INTO SQL_BOYS.Usuario (username, contraseña, habilitadx)

	VALUES ('admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1) /* Password: w23e */

INSERT INTO SQL_BOYS.Sucursal (cp_sucursal, nombre, domicilio, habilitadx)

	SELECT DISTINCT

		[Sucursal_Codigo_Postal] AS cp_sucursal,
		[Sucursal_Nombre] AS nombre,
		[Sucursal_Dirección] AS domicilio,
		habilitada = 1

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE Sucursal_Codigo_Postal IS NOT NULL

INSERT INTO SQL_BOYS.Rol_De_Usuario_Por_Sucursal (id_rol, id_usuario, cp_sucursal)

	VALUES (2, 1, 7210)

INSERT INTO SQL_BOYS.Cliente(dni_cliente, nombre, apellido, nacimiento, mail, domicilio, codigo_postal, telefono, habilitadx)
	
	SELECT DISTINCT

		c1.view_dni_cliente AS dni_cliente,
		c1.view_apellido AS apellido,
		c1.view_nombre AS nombre,
		c1.view_nacimiento AS nacimiento,
		c1.view_mail AS mail,
		c1.view_domicilio AS domicilio,
		c1.view_codigo_postal AS codigo_postal,
		telefono = 0,
		habilitadx = 1

	FROM SQL_BOYS.View_Cliente c1
	
	WHERE NOT EXISTS (SELECT 1 FROM SQL_BOYS.View_Cliente_Conflictivo cc WHERE c1.view_dni_cliente = cc.view_dni_cliente)

SET IDENTITY_INSERT SQL_BOYS.Rendicion ON;

INSERT INTO SQL_BOYS.Rendicion (numero_rendicion, importe_comision, fecha_rendicion)

	SELECT DISTINCT
		
		[Rendicion_Nro] AS numero_rendicion,
		[ItemRendicion_Importe] AS importe_comision,
		[Rendicion_Fecha] AS fecha_rendicion

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE Rendicion_Nro IS NOT NULL

SET IDENTITY_INSERT SQL_BOYS.Rendicion OFF;

SET IDENTITY_INSERT SQL_BOYS.Rubro ON

INSERT INTO SQL_BOYS.Rubro (id_rubro, descripcion)

	SELECT DISTINCT

		view_id_rubro AS id_rubro,
		view_descripcion AS descripcion 
		
	FROM SQL_BOYS.View_Empresa_Rubro

SET IDENTITY_INSERT SQL_BOYS.Rubro OFF

INSERT INTO SQL_BOYS.Empresa (nombre, cuit, domicilio, dia_rendicion, porcentaje_comision, habilitadx, id_rubro)

	SELECT DISTINCT 

		view_nombre AS nombre,
		view_cuit AS cuit,
		view_domicilio AS domicilio,
		dia_rendicion = (SELECT TOP 1 DAY (r.fecha_rendicion) FROM SQL_BOYS.Rendicion r, SQL_BOYS.View_Factura f, SQL_BOYS.View_Empresa_Rubro e WHERE r.numero_rendicion = f.view_numero_rendicion AND f.view_cuit_empresa = e.view_cuit ORDER BY r.fecha_rendicion DESC),
		porcentaje_comision = 5,
		habilitadx = 1,
		view_id_rubro AS id_rubro

	FROM SQL_BOYS.View_Empresa_Rubro;

INSERT INTO SQL_BOYS.Factura (numero_factura, factura_monto_total, factura_fecha_alta, factura_fecha_vencimiento, dni_cliente, id_empresa, numero_rendicion)

	SELECT
		
		f.view_numero_factura AS numero_factura,
		f.view_factura_monto_total AS factura_monto_total,
		f.view_factura_fecha_alta AS factura_fecha_alta,
		f.view_factura_fecha_vencimiento AS factura_fecha_vencimiento,
		f.view_dni_cliente AS dni_cliente,
		e.id_empresa AS id_empresa,
		f.view_numero_rendicion AS numero_rendicion

	FROM SQL_BOYS.View_Factura_Con_Rendicion f

	JOIN SQL_BOYS.Empresa e ON f.view_cuit_empresa = e.cuit

	WHERE NOT EXISTS (SELECT 1 FROM SQL_BOYS.View_Cliente_Conflictivo c WHERE f.view_dni_cliente = c.view_dni_cliente)

INSERT INTO SQL_BOYS.Medio_De_Pago (descripcion)

	SELECT DISTINCT 

		view_medio_de_pago AS descripcion

	FROM SQL_BOYS.View_Pago_Medio_De_Pago

SET IDENTITY_INSERT SQL_BOYS.Pago ON;

INSERT INTO SQL_BOYS.Pago (numero_pago, monto_total, fecha_pago, id_medio_de_pago, dni_cliente, cp_sucursal)

	SELECT DISTINCT
		
		p.view_numero_pago AS numero_pago,
		p.view_monto_total AS monto_total,
		p.view_fecha_pago AS fecha_pago,
		m.id_medio_de_pago AS id_medio_de_pago,
		p.view_dni_cliente AS view_dni_cliente,
		p.view_cp_sucursal AS view_cp_sucursal

	FROM

		SQL_BOYS.View_Pago_Medio_De_Pago p

    JOIN SQL_BOYS.Medio_De_Pago m ON m.descripcion = p.view_medio_de_pago

	WHERE NOT EXISTS (SELECT 1 FROM SQL_BOYS.View_Cliente_Conflictivo c WHERE c.view_dni_cliente = p.view_dni_cliente)

SET IDENTITY_INSERT SQL_BOYS.Pago OFF;

INSERT INTO SQL_BOYS.Item (nombre, monto, cantidad, numero_factura)

	SELECT DISTINCT

		'Sin nombre' AS nombre,
		i.view_monto AS monto,
		i.view_cantidad AS cantidad,
		i.view_numero_factura AS numero_factura

	FROM SQL_BOYS.View_Item i

	JOIN SQL_BOYS.Factura f ON f.numero_factura = i.view_numero_factura;

INSERT INTO SQL_BOYS.Item_Pago (id_item, numero_factura, numero_pago)
	
	SELECT DISTINCT

		i.id_item AS id_item,
		i.numero_factura AS numero_factura,
		p.numero_pago AS numero_pago

	FROM SQL_BOYS.View_Item vi

	JOIN SQL_BOYS.Item i ON i.numero_factura = vi.view_numero_factura
	JOIN SQL_BOYS.Pago p ON p.numero_pago = vi.view_numero_pago

INSERT INTO SQL_BOYS.Item_Rendicion(id_item, numero_rendicion)

	SELECT DISTINCT

		i.id_item AS id_item,
		r.numero_rendicion AS numero_rendicion

	FROM SQL_BOYS.View_Item vi

	JOIN SQL_BOYS.Item i ON i.numero_factura = vi.view_numero_factura
	JOIN SQL_BOYS.Rendicion r ON r.numero_rendicion = vi.view_numero_rendicion - 1

GO

/* Limpiamos las vistas temporales para la migración */

DROP VIEW

	SQL_BOYS.View_Cliente,
	SQL_BOYS.View_Cliente_Conflictivo,
	SQL_BOYS.View_Empresa_Rubro,
	SQL_BOYS.View_Factura,
	SQL_BOYS.View_Factura_Con_Rendicion,
	SQL_BOYS.View_Pago_Medio_De_Pago,
	SQL_BOYS.View_Item