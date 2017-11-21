/* Se crean las entidades del sistema en función del DER realizado */

CREATE SCHEMA SQL_BOYS

GO

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
	habilitadx BIT NOT NULL,
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
	monto NUMERIC(18, 2) NOT NULL CHECK (monto > 0),
	cantidad INT NOT NULL CHECK (cantidad > 0),
	numero_factura NUMERIC(18, 0) FOREIGN KEY REFERENCES SQL_BOYS.Factura(numero_factura) NOT NULL
	CONSTRAINT monto_positivo CHECK (monto > 0 AND cantidad > 0)
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

	INTO SQL_BOYS.Tabla_Maestra_Conflictiva

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
		('Gestionar roles'),
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
		
		(1 , 1) , (2 , 1) , (3 , 1) , (4 , 1) , (5 , 1) , (6 , 1),
		(1 , 2) , (2 , 2) , (3 , 2) , (4 , 2) , (5 , 2) , (6 , 2) , (7 , 2) , (8 , 2)

INSERT INTO SQL_BOYS.Usuario (username, contraseña, habilitadx)

	VALUES 
	
		('admin',			'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1),		-- Password: w23e
		('cobrador1',		'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1),		-- Password: cobrador
		('cobrador2',		'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1),		-- Password: cobrador
		('cobrador3',		'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1),		-- Password: cobrador
		('cobrador4',		'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1),		-- Password: cobrador
		('deshabilitado',	'68de79aa60784d315201bac92fedae8297eed7c10f105b1e7704bd193244e27b', 0),		-- Password: deshabilitado
		('a',				'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb', 1)		-- Password: a

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

INSERT INTO SQL_BOYS.Cliente(dni_cliente,apellido ,nombre , nacimiento, mail, domicilio, codigo_postal, telefono, habilitadx)
	
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

INSERT INTO SQL_BOYS.Factura (numero_factura, factura_monto_total, factura_fecha_alta, factura_fecha_vencimiento, habilitadx, dni_cliente, id_empresa, numero_rendicion)

	SELECT
		
		f.view_numero_factura AS numero_factura,
		f.view_factura_monto_total AS factura_monto_total,
		f.view_factura_fecha_alta AS factura_fecha_alta,
		f.view_factura_fecha_vencimiento AS factura_fecha_vencimiento,
		habilitadx = 1,
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

GO

/*Creamos funciones y procedimientos necesarios*/

/*ABM Sucursal*/

CREATE FUNCTION SQL_BOYS.obtenerSucursalPorNombre(@nombre NVARCHAR(50))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@nombre IS NULL) OR (s.nombre LIKE concat(@nombre,'%')))

GO

CREATE FUNCTION SQL_BOYS.obtenerSucursalPorDireccion(@direccion NVARCHAR(50))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@direccion IS NULL) OR (s.domicilio LIKE concat(@direccion,'%')))

GO

CREATE FUNCTION SQL_BOYS.obtenerSucursalPorCodigoPostal(@CP NUMERIC(18,0))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@CP = 0) OR (s.cp_sucursal = @CP))

GO

CREATE FUNCTION SQL_BOYS.obtenerSucursalPorFiltrado(@CP NUMERIC(18,0),@nombre NVARCHAR(50),@domicilio NVARCHAR(50))
RETURNS table

return (
	
		SELECT * FROM SQL_BOYS.Sucursal s
			where s.cp_sucursal IN (SELECT s.cp_sucursal FROM SQL_BOYS.obtenerSucursalPorCodigoPostal(@CP) as s) AND
			s.nombre IN (SELECT s.nombre FROM SQL_BOYS.obtenerSucursalPorNombre(@nombre) as s) AND
			s.domicilio IN (SELECT s.domicilio FROM SQL_BOYS.obtenerSucursalPorDireccion(@domicilio) as s)

	)

GO

CREATE PROCEDURE SQL_BOYS.actualizarSucursal(@CP NUMERIC(18,0),@nombre nvarchar(50), @domicilio nvarchar(50), @estado bit) AS

UPDATE Sucursal SET nombre = @nombre ,domicilio = @domicilio ,habilitadx = @estado WHERE cp_sucursal = @CP

GO

CREATE PROCEDURE SQL_BOYS.darDeBajaSucursal(@CP NUMERIC(18,0)) AS

UPDATE Sucursal SET habilitadx = 0 WHERE cp_sucursal = @CP

GO

/*Devolución*/

create function SQL_BOYS.facturasDevolvibles()
returns table

	return	(	
	
				-- Obtengo las que no fueron devueltas, fueron pagas y no han sido rendidas
				select f.numero_factura from SQL_BOYS.Factura f left join
					SQL_BOYS.Devolucion d on f.numero_factura = d.numero_factura left join
					SQL_BOYS.Item_Pago ip on f.numero_factura = ip.numero_pago
					
					where d.numero_factura is null and f.numero_rendicion is null and ip.numero_factura is not null

			)

GO

create procedure SQL_BOYS.devolverFacturaPaga(@numero_factura int, @motivo nvarchar(255), @fecha_actual nvarchar(10))
as begin

	if(exists(select fd.numero_factura from SQL_BOYS.facturasDevolvibles() fd where fd.numero_factura = @numero_factura))
	begin

		declare @numero_pago int

		-- Tomo el numero del pago a borrar
		set @numero_pago = (select top 1 ip.numero_pago from SQL_BOYS.Item_Pago ip where ip.numero_factura = @numero_factura)

		declare @devolucion_de_factura char

		-- En caso de que falle la transaccion, es conveniente que la base haga rollback automaticamente
		set xact_abort on

		begin transaction @devolucion_de_factura

			delete from SQL_BOYS.Item_Pago
				where numero_pago = @numero_pago	

			delete from SQL_BOYS.Pago
				where numero_pago = @numero_pago

			-- Una vez borrados los pagos y los items, puedo insertar la devolucion correspondiente
			insert into SQL_BOYS.Devolucion (fecha_devolucion, motivo, numero_factura) values
				(SQL_BOYS.obtenerFecha(@fecha_actual), @motivo, @numero_factura)

		commit transaction @devolucion_de_factura

	end

	else

	begin

		;throw 50071, 'No se pudo devolver la factura, ya que no cumplia los requisitos para ser devuelta', 1

	end

end

GO

/*ABM Empresa*/

CREATE VIEW SQL_BOYS.Empresa_View_Empresa_Con_Rubro AS

		SELECT e.id_empresa, e.nombre, e.cuit, e.domicilio, e.dia_rendicion, e.porcentaje_comision, e.id_rubro, r.descripcion , e.habilitadx
		
		FROM SQL_BOYS.Empresa e

		JOIN SQL_BOYS.Rubro r ON r.id_rubro = e.id_rubro

GO

CREATE FUNCTION SQL_BOYS.obtenerRubros () RETURNS TABLE

	RETURN SELECT r.id_rubro, r.descripcion FROM SQL_BOYS.Rubro r

GO

CREATE FUNCTION SQL_BOYS.id_Rubro (@nombre_rubro AS NVARCHAR(255)) RETURNS INT AS

	BEGIN

		DECLARE @id INT = (SELECT id_rubro FROM SQL_BOYS.Rubro WHERE descripcion = @nombre_rubro)

		RETURN @id

	END

GO

CREATE PROCEDURE SQL_BOYS.altaDeEmpresa (@id_empresa AS INT, @nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @porcentaje_comision AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS
	
	BEGIN
		
		BEGIN TRANSACTION

			INSERT INTO SQL_BOYS.Empresa (nombre, cuit, domicilio, dia_rendicion, porcentaje_comision, habilitadx, id_rubro)

			VALUES (@nombre, @cuit, @domicilio, @dia_rendicion, @porcentaje_comision, @habilitadx, SQL_BOYS.id_Rubro(@nombre_rubro))

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.bajaDeEmpresa (@id_empresa AS INT, @nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @porcentaje_comision AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS

	BEGIN

		BEGIN TRANSACTION

			UPDATE SQL_BOYS.Empresa

			SET habilitadx = 0

			WHERE id_empresa = @id_empresa

		COMMIT

	END

GO

ALTER PROCEDURE SQL_BOYS.modificacionDeEmpresa (@id_empresa AS INT, @nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @porcentaje_comision AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS

	BEGIN

		BEGIN TRANSACTION

			UPDATE SQL_BOYS.Empresa

			SET
			
				nombre = @nombre,
				cuit = @cuit,
				domicilio = @domicilio,
				dia_rendicion = @dia_rendicion,
				porcentaje_comision = @porcentaje_comision,
				habilitadx = @habilitadx,
				id_rubro = SQL_BOYS.id_Rubro(@nombre_rubro)

			WHERE id_empresa = @id_empresa

		COMMIT

	END

GO

CREATE FUNCTION SQL_BOYS.filtrarEmpresa (@nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @nombre_rubro AS NVARCHAR(50), @id_empresa AS INT) RETURNS TABLE

	RETURN
	
		SELECT e.id_empresa, e.nombre, e.cuit, e.domicilio, e.dia_rendicion, e.porcentaje_comision, e.id_rubro, e.descripcion , e.habilitadx
		
		FROM SQL_BOYS.Empresa_View_Empresa_Con_Rubro e

		WHERE

			(LEN(@nombre) = 0 AND LEN(@cuit) = 2 AND LEN(@nombre_rubro) = 0 AND @id_empresa = 0) OR
			
			(LEN(@nombre) != 0 AND e.nombre LIKE @nombre + '%') OR

			(e.cuit = @cuit) OR

			(e.descripcion = @nombre_rubro) OR

			(e.id_empresa = @id_empresa)

GO

CREATE FUNCTION SQL_BOYS.cantidadDeFacturasPorRendirDeEmpresa(@id_empresa INT) RETURNS INT
	
	BEGIN

		RETURN (SELECT COUNT(*) FROM SQL_BOYS.Empresa e JOIN SQL_BOYS.Factura f ON f.id_empresa = e.id_empresa WHERE f.id_empresa = @id_empresa AND f.numero_rendicion IS NULL)

	END

GO

CREATE FUNCTION SQL_BOYS.esFechaValida(@fecha datetime, @anio int, @trimestre int)
RETURNS bit
AS
BEGIN

	declare @mes int

	set @mes = month(@fecha)

	declare @trimesteDelAnio int

		if(@mes >= 0 and @mes <= 2)
			SET @trimesteDelAnio = 1

		if(@mes >= 3 and @mes <= 5)
			SET @trimesteDelAnio = 2

		if(@mes >= 6 and @mes <= 8)
			SET @trimesteDelAnio = 3
		
		if(@mes >= 9 and @mes <= 11)
			SET @trimesteDelAnio = 4

	if(year(@fecha) = @anio and @trimesteDelAnio = @trimestre)
		return 1

	return 0

END

GO

CREATE FUNCTION SQL_BOYS.clientesConMasPagos(@anio int, @trimestre int)
RETURNS TABLE
AS 

	RETURN (

		select top 5 c.*, count(p.dni_cliente) as cantidad_de_pagos from SQL_BOYS.Cliente c join SQL_BOYS.Pago p on c.dni_cliente = p.dni_cliente
			where SQL_BOYS.esFechaValida(p.fecha_pago, @anio, @trimestre) = 1
			group by c.dni_cliente, c.nombre, c.apellido, c.mail, c.nacimiento, c.telefono, c.codigo_postal, c.habilitadx, c.domicilio
			order by cantidad_de_pagos DESC

	)

GO

CREATE FUNCTION SQL_BOYS.clientesCumplidores(@anio int, @trimestre int)
RETURNS TABLE
AS 

	RETURN (

		select top 5 c.*, (sum(ip.numero_factura) * 100 / sum(f.numero_factura)) as porcentaje_facturas_pagadas from SQL_BOYS.Cliente c 
			join SQL_BOYS.Pago p on c.dni_cliente = p.dni_cliente
			join SQL_BOYS.Item_Pago ip on p.numero_pago = ip.numero_pago
			join SQL_BOYS.Factura f on c.dni_cliente = f.dni_cliente

			where SQL_BOYS.esFechaValida(p.fecha_pago, @anio, @trimestre) = 1 and SQL_BOYS.esFechaValida(f.factura_fecha_alta, @anio, @trimestre) = 1
			group by c.dni_cliente, c.nombre, c.apellido, c.mail, c.nacimiento, c.telefono, c.codigo_postal, c.habilitadx, c.domicilio
		
			order by porcentaje_facturas_pagadas DESC

	)

GO

CREATE FUNCTION SQL_BOYS.empresasConMayorMontoRendido(@anio int, @trimestre int)
RETURNS TABLE
AS 

	RETURN (

		select top 5 e.*, sum(i.monto) as monto_rendido from SQL_BOYS.Empresa e
			join SQL_BOYS.Factura f on e.id_empresa = f.id_empresa
			join SQL_BOYS.Rendicion r on f.numero_rendicion = r.numero_rendicion
			join SQL_BOYS.Item_Rendicion ir on r.numero_rendicion = ir.numero_rendicion
			join SQL_BOYS.Item i on ir.id_item = i.id_item

			where SQL_BOYS.esFechaValida(r.fecha_rendicion, @anio, @trimestre) = 1

			group by e.id_empresa, e.nombre, e.cuit, e.domicilio, e.porcentaje_comision, e.id_rubro, e.dia_rendicion, e.habilitadx

			order by monto_rendido desc

	)

GO

CREATE FUNCTION SQL_BOYS.porcentajeDeFacturasCobradasPorEmpresa(@anio int, @trimestre int)
RETURNS table
AS

	return (
	
		SELECT top 5 e.*, sum (

					case 
						when e.id_empresa = f.id_empresa and f.numero_factura = i.numero_factura and i.numero_pago IS NOT NULL then 1
						else 0
					end


				) * 100 / sum (
				
					case 
						when e.id_empresa = f.id_empresa then 1
						else 0
					end
				
				) as porcentaje_facturas_cobradas -- Cantidad de pagos que tuvo la empresa por cien, dividido la cantidad de facturas que tuvo
				
				from SQL_BOYS.Empresa e join 
				SQL_BOYS.Factura f on e.id_empresa = f.id_empresa join 
				SQL_BOYS.Item_Pago i on f.numero_factura = i.numero_factura join 
				SQL_BOYS.Pago p on i.numero_pago = p.numero_pago
			
			where SQL_BOYS.esFechaValida(p.fecha_pago, @anio, @trimestre) = 1

			group by e.id_empresa, e.nombre, e.porcentaje_comision, e.cuit, e.domicilio, e.id_rubro, e.dia_rendicion, e.habilitadx

			order by porcentaje_facturas_cobradas DESC
			

		)

GO

/*ABM Factura*/

CREATE FUNCTION SQL_BOYS.obtenerEmpresa(@unCuit NVARCHAR(255)) RETURNS INT AS
	
	BEGIN

		RETURN (SELECT id_empresa FROM SQL_BOYS.Empresa WHERE cuit = @unCuit)

	END

GO

CREATE PROCEDURE SQL_BOYS.altaDeFactura (@numero_factura NUMERIC(18, 0), @factura_monto_total NUMERIC(18, 2), @factura_fecha_alta DATETIME, @factura_fecha_vencimiento DATETIME, @habilitadx BIT, @dni_cliente NUMERIC(18, 0), @cuit_empresa NVARCHAR(255)) AS
	
	BEGIN
		
		BEGIN TRANSACTION

			INSERT INTO SQL_BOYS.Factura(numero_factura, factura_monto_total, factura_fecha_alta, factura_fecha_vencimiento, habilitadx, dni_cliente, id_empresa)

				VALUES (@numero_factura, @factura_monto_total, @factura_fecha_alta, @factura_fecha_vencimiento, @habilitadx, @dni_cliente, SQL_BOYS.obtenerEmpresa(@cuit_empresa))

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.altaDeItem (@nombre NVARCHAR(255), @monto NUMERIC(18, 2), @cantidad INT, @numero_factura NUMERIC(18, 0)) AS
	
	BEGIN

		BEGIN TRANSACTION

			INSERT INTO SQL_BOYS.Item(nombre, monto, cantidad, numero_factura)

				VALUES (@nombre, @monto, @cantidad, @numero_factura)

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.bajaDeFactura (@numero_factura NUMERIC(18, 0), @factura_monto_total NUMERIC(18, 2), @factura_fecha_alta DATETIME, @factura_fecha_vencimiento DATETIME, @habilitadx BIT, @dni_cliente NUMERIC(18, 0), @cuit_empresa NVARCHAR(255)) AS

	BEGIN

		BEGIN TRANSACTION

			UPDATE SQL_BOYS.Factura

				SET habilitadx = 0

				WHERE numero_factura = @numero_factura

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.modificacionDeFactura (@numero_factura NUMERIC(18, 0), @factura_monto_total NUMERIC(18, 2), @factura_fecha_alta DATETIME, @factura_fecha_vencimiento DATETIME, @habilitadx BIT, @dni_cliente NUMERIC(18, 0), @cuit_empresa NVARCHAR(255)) AS
	
	BEGIN

		BEGIN TRANSACTION

			UPDATE SQL_BOYS.Factura

				SET habilitadx = 1

				WHERE numero_factura = @numero_factura

		COMMIT

	END

GO

CREATE FUNCTION SQL_BOYS.buscarFactura (@numero_factura NUMERIC(18, 0)) RETURNS BIT AS
	
	BEGIN

		DECLARE @vof BIT

		IF (EXISTS(SELECT 1 FROM SQL_BOYS.Factura WHERE numero_factura = @numero_factura))
		
			SET @vof = 1
		
		ELSE

			SET @vof = 0

		RETURN @vof

	END

GO

CREATE FUNCTION SQL_BOYS.buscarCliente (@dni_cliente NUMERIC(18, 0)) RETURNS BIT AS
	
	BEGIN

		DECLARE @vof BIT

		IF (EXISTS(SELECT 1 FROM SQL_BOYS.Cliente WHERE dni_cliente = @dni_cliente))
		
			SET @vof = 1
		
		ELSE

			SET @vof = 0

		RETURN @vof

	END

GO

CREATE FUNCTION SQL_BOYS.darItems (@numero_factura NUMERIC(18, 0)) RETURNS TABLE

	RETURN (
				SELECT
				
					i.id_item,
					i.nombre,
					i.monto,
					i.cantidad
					
				FROM SQL_BOYS.Item i

				WHERE i.numero_factura = @numero_factura
			)

GO

CREATE VIEW SQL_BOYS.viewFacturaBuscador AS

		SELECT DISTINCT
		
			f.numero_factura AS Numero,
			f.factura_monto_total AS Monto,
			f.factura_fecha_alta AS Alta,
			f.factura_fecha_vencimiento AS Vencimiento,
			f.dni_cliente AS Cliente,
			e.nombre AS Empresa,
			e.cuit AS Cuit_Empresa,
			ip.numero_pago AS Pago,
			f.numero_rendicion AS Rendición,
			f.habilitadx AS Habilitadx

		FROM SQL_BOYS.Factura f

		JOIN SQL_BOYS.Empresa e ON f.id_empresa = e.id_empresa
		LEFT JOIN SQL_BOYS.Item_Pago ip ON f.numero_factura = ip.numero_factura
		LEFT JOIN SQL_BOYS.Item_Rendicion ir ON f.numero_factura = ir.numero_rendicion

GO

CREATE FUNCTION SQL_BOYS.filtrarFactura (@numero_factura NUMERIC(18, 0), @cuit_empresa NVARCHAR(255), @dni_cliente NUMERIC(18, 0)) RETURNS TABLE AS
	
	RETURN

		SELECT
		
			Numero,
			Monto,
			Alta,
			Vencimiento,
			Cliente,
			Empresa,
			Cuit_Empresa,
			Pago,
			Rendición,
			Habilitadx

		FROM SQL_BOYS.viewFacturaBuscador

		WHERE

			(@numero_factura = 0 AND LEN(@cuit_empresa) = 0 AND @dni_cliente = 0) OR
			Numero = @numero_factura OR
			Cuit_Empresa = @cuit_empresa OR
			Cliente = @dni_cliente

GO

/*Login*/

CREATE FUNCTION SQL_BOYS.obtenerUsuario(@nombre nvarchar(255))
RETURNS table

	return (
	
		select u.* from SQL_BOYS.Usuario u
			where u.username = @nombre

	)

GO

/*Registro de pago*/

CREATE FUNCTION SQL_BOYS.obtenerProximoNroPago() 
RETURNS NUMERIC(18,0) AS BEGIN

DECLARE @proximoId NUMERIC(18,0)

SELECT @proximoId = ident_current('SQL_BOYS.Pago') + ident_incr('SQL_BOYS.Pago')

RETURN @proximoId

END

GO

CREATE FUNCTION SQL_BOYS.obtenerFactura(@nroFactura NUMERIC(18,0), @idEmpresa int,@diaV int,@mesV int,@anioV int)
RETURNS table AS 

	return(SELECT f.numero_factura,f.factura_monto_total,f.factura_fecha_alta,f.factura_fecha_vencimiento,f.habilitadx,f.dni_cliente,f.id_empresa FROM Factura f WHERE f.numero_factura = @nroFactura AND f.id_empresa = @idEmpresa AND 
	
	YEAR(f.factura_fecha_vencimiento) = @anioV AND MONTH(f.factura_fecha_vencimiento) = @mesV AND DAY(f.factura_fecha_vencimiento) = @diaV AND @nroFactura
	
	NOT IN (SELECT it.numero_factura FROM SQL_BOYS.Item_Pago it) )

GO

CREATE FUNCTION SQL_BOYS.existeCliente(@DNI NUMERIC(18,0))
RETURNS table as 

	return(SELECT c.dni_cliente, c.habilitadx FROM SQL_BOYS.Cliente c WHERE c.dni_cliente = @DNI)

GO

CREATE PROCEDURE SQL_BOYS.insertarItemPagoDeFactura(@nroPago NUMERIC(18,0), @nroFactura NUMERIC(18,0))
AS
BEGIN

INSERT INTO SQL_BOYS.Item_Pago(id_item, numero_factura, numero_pago)

SELECT it.id_item, @nroFactura, @nroPago FROM SQL_BOYS.Item it WHERE it.numero_factura = @nroFactura

END

GO

/*Rendición*/

create function SQL_BOYS.obtenerFecha(@fecha_actual nvarchar(10))
returns date
as begin

	return (select convert(date, @fecha_actual))

end

GO

create function SQL_BOYS.obtenerFacturasARendir(@id_empresa int, @fecha_actual nvarchar(10))
returns table

return 
			(select f.* from SQL_BOYS.Factura f
					where f.numero_rendicion is null and f.id_empresa = @id_empresa and f.factura_fecha_alta <= SQL_BOYS.obtenerFecha(@fecha_actual)
						and exists	(select * from SQL_BOYS.Item_Pago ip
										where ip.numero_factura = f.numero_factura	
									) -- fue pagada
						and not exists	(select * from SQL_BOYS.Devolucion d
											where d.numero_factura = f.numero_factura
								
										) -- no fue devuelta
			)

GO

create function SQL_BOYS.empresasARendir(@fecha_actual nvarchar(10))
returns table

	return (

		select e.id_empresa, e.cuit, e.nombre, e.domicilio, (select count(*) from SQL_BOYS.obtenerFacturasARendir(e.id_empresa, @fecha_actual)) as facturas_a_rendir from SQL_BOYS.Empresa e
			where e.habilitadx = 1 and e.dia_rendicion = day(SQL_BOYS.obtenerFecha(@fecha_actual)) and SQL_BOYS.obtenerFecha(@fecha_actual) != (select top 1 r.fecha_rendicion from SQL_BOYS.Factura f join SQL_BOYS.Rendicion r on f.numero_rendicion = r.numero_rendicion
																		where f.id_empresa = e.id_empresa
																		
																		order by r.fecha_rendicion desc	
																	)

					and exists(select * from SQL_BOYS.obtenerFacturasARendir(e.id_empresa, @fecha_actual))

	)

GO

create procedure SQL_BOYS.rendirFacturas(@id_empresa int, @fecha_actual nvarchar(10))
as
begin

	-- Verifico que la empresa que me pedis rendir, sea rendible
	if(exists(select e.* from SQL_BOYS.empresasARendir(@fecha_actual) e where e.id_empresa = @id_empresa))
	begin

		declare @porcentaje_comision int

		-- Obtengo el porcentaje de la empresa
		set @porcentaje_comision = (select e.porcentaje_comision from SQL_BOYS.Empresa e where e.id_empresa = @id_empresa)

		-- Declaro mi futura id rendicion
		declare @id_numero_rendicion int

		-- Inserto en la rendicion la suma de las facturas a rendir
		insert into SQL_BOYS.Rendicion (importe_comision, fecha_rendicion)
			values ((select sum(o.factura_monto_total) from SQL_BOYS.obtenerFacturasARendir(@id_empresa, @fecha_actual) o) * @porcentaje_comision / 100, SQL_BOYS.obtenerFecha(@fecha_actual))
		
		-- Obtengo el id de la rendicion ingresada
		set @id_numero_rendicion = (select scope_identity())

		declare @numero_factura_cr int

		-- Obtengo las facturas a rendir de la empresa solicitada
		declare cr_facturas cursor local for 
			select fs.numero_factura from SQL_BOYS.obtenerFacturasARendir(@id_empresa, @fecha_actual) fs

		open cr_facturas

		fetch next from cr_facturas into @numero_factura_cr

		-- Recorro las facturas a rendir
		while @@FETCH_STATUS = 0
		begin

			print '@numero_factura_cr=' + str(@numero_factura_cr)
			
			declare @id_item_factura_cr int

			-- Declaro un nuevo cursor para poder agarrar a cada item de las facturas que van a ser rendidas
			declare cr_item_facturas cursor local for
				select i.id_item from SQL_BOYS.Item i where i.numero_factura = @numero_factura_cr

			open cr_item_facturas
		
			fetch next from cr_item_facturas into @id_item_factura_cr

			-- Recorro los items a ser agregados como rendidos
			while @@FETCH_STATUS = 0
			begin

				print '@id_item_factura_cr=' + str(@id_item_factura_cr)

				-- Los inserto con el id de la rendicion que obtuve previamente
				insert into SQL_BOYS.Item_Rendicion (id_item, numero_rendicion) values
					(@id_item_factura_cr, @id_numero_rendicion)

				fetch next from cr_item_facturas into @id_item_factura_cr

			end

			close cr_item_facturas

			deallocate cr_item_facturas

			-- Ahora la factura pasa a estar rendida
			update SQL_BOYS.Factura
				set numero_rendicion = @id_numero_rendicion
				where numero_factura = @numero_factura_cr

			fetch next from cr_facturas into @numero_factura_cr

		end  

		close cr_facturas

		deallocate cr_facturas

	end

	else

	begin

		-- No habia facturas para rendir
		;throw 50069, 'No hay facturas para rendir para esta empresa', 1

	end

end

GO

/*Seleccionar sucursal y rol*/

CREATE FUNCTION SQL_BOYS.obtenerSucursales(@id_usuario int)
RETURNS table

	return (

		select s.* from SQL_BOYS.Rol_De_Usuario_Por_Sucursal as rus join SQL_BOYS.Sucursal s on rus.cp_sucursal = s.cp_sucursal
			where @id_usuario = rus.id_usuario

	)

GO

CREATE FUNCTION SQL_BOYS.obtenerRol(@id_rol int)
RETURNS table

	return (

		select r.nombre as rol, f.nombre as funcionalidad from SQL_BOYS.Rol r join SQL_BOYS.Funcionalidad_Por_Rol as fr on r.id_rol = fr.id_rol join SQL_BOYS.Funcionalidad f on fr.id_funcionalidad = f.id_funcionalidad
			where @id_rol = r.id_rol

	)

GO

CREATE FUNCTION SQL_BOYS.obtenerRoles(@id_usuario int, @id_sucursal int)
RETURNS TABLE

	return (

		select r.* from SQL_BOYS.Rol_De_Usuario_Por_Sucursal as rus join SQL_BOYS.Rol as r on rus.id_rol = r.id_rol
			where @id_usuario = rus.id_usuario and @id_sucursal = rus.cp_sucursal

	)

GO

/*ABM Rol*/

CREATE PROCEDURE SQL_BOYS.actualizarRol(@idRol INT,@nombre nvarchar(255), @estado bit) AS BEGIN

UPDATE SQL_BOYS.Rol SET nombre = @nombre ,habilitadx = @estado WHERE id_rol = @idRol

DELETE FROM SQL_BOYS.Funcionalidad_Por_Rol WHERE id_rol = @idRol 

END

GO

CREATE PROCEDURE SQL_BOYS.darDeBajaRol(@idRol INT) AS

UPDATE SQL_BOYS.Rol SET habilitadx = 0 WHERE id_rol = @idRol

GO

CREATE FUNCTION SQL_BOYS.obtenerFuncionalidadesDeRol(@idRol INT) 
RETURNS TABLE AS 

RETURN (SELECT f.id_funcionalidad, f.nombre FROM SQL_BOYS.Funcionalidad f JOIN SQL_BOYS.Funcionalidad_Por_Rol fxr ON (f.id_funcionalidad = fxr.id_funcionalidad) WHERE fxr.id_rol = @idRol)

GO

CREATE FUNCTION SQL_BOYS.obtenerProximoIdRol() 
RETURNS INT AS BEGIN

DECLARE @proximoId INT

SELECT @proximoId = ident_current('SQL_BOYS.Rol') + ident_incr('SQL_BOYS.Rol')

RETURN @proximoId

END

