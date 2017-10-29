/* Se crean vistas auxiliares para mejorar la performance de la migración, sobretodo cuando es necesario consultar a la tabla maestra más de una vez cuando el resultado de una consulta ya tiene todo lo necesario. */

/* Vista de todos los clientes del sistema, para optimizar la búsqueda de clientes con el mismo mail. */

CREATE VIEW View_Cliente AS

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

CREATE VIEW View_Cliente_Conflictivo AS

	SELECT

		c1.view_dni_cliente AS view_dni_cliente,
		c1.view_apellido AS view_apellido,
		c1.view_nombre AS view_nombre,
		c1.view_nacimiento AS view_nacimiento,
		c1.view_mail AS view_mail,
		c1.view_domicilio AS view_domicilio,
		c1.view_codigo_postal AS view_codigo_postal

	FROM View_Cliente c1, View_Cliente c2
	
	WHERE c1.view_dni_cliente != c2.view_dni_cliente AND c1.view_mail = c2.view_mail

GO

/* Vista para no recorrer toda la tabla maestra de nuevo sólo para buscar el rubro de una empresa. */

CREATE VIEW View_Empresa_Rubro AS

	SELECT DISTINCT

		[Empresa_Nombre] AS view_nombre,
		[Empresa_Cuit] AS view_cuit,
		[Empresa_Direccion] AS view_domicilio,
		[Empresa_Rubro] AS view_id_rubro,
		[Rubro_Descripcion] AS view_descripcion

	FROM [GD2C2017].[gd_esquema].[Maestra]

GO

/* Vista para no tener que recorrer la tabla maestra de nuevo para buscar facturas. */

CREATE VIEW View_Factura AS

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

/* Vista para no tener que recorrer la tabla otra vez para obtener los medios de pago o los pagos. */

CREATE VIEW View_Pago_Medio_De_Pago AS

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

CREATE VIEW View_Item AS

	SELECT DISTINCT

		m.[ItemFactura_Monto] AS view_monto,
		m.[ItemFactura_Cantidad] AS view_cantidad,
		m.[Nro_Factura] AS view_numero_factura,
		m.[ItemPago_nro] AS view_numero_pago,
		m.[ItemRendicion_nro] AS view_numero_rendicion

	FROM [GD2C2017].[gd_esquema].[Maestra] m

GO

/* Como los clientes conflictivos también tienen facturas, pagos y rendiciones, decidimos apartar las filas de la tabla maestra de dichos clientes. */

CREATE VIEW View_Tabla_Maestra_Conflictiva AS

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

	WHERE EXISTS (SELECT 1 FROM View_Cliente_Conflictivo WHERE view_dni_cliente = [Cliente-Dni])