GO

CREATE VIEW View_Cliente AS

	SELECT DISTINCT

		[Cliente-Dni] AS view_dni,
		[Cliente-Apellido] AS view_apellido,
		[Cliente-Nombre] AS view_nombre,
		[Cliente-Fecha_Nac] AS view_nacimiento,
		Cliente_Mail AS view_mail,
		Cliente_Direccion AS view_domicilio,
		Cliente_Codigo_Postal AS view_codigo_postal

	FROM [GD2C2017].[gd_esquema].[Maestra]

GO

CREATE VIEW View_Empresa_Rubro AS

	SELECT DISTINCT

		[Empresa_Nombre] AS view_nombre,
		[Empresa_Cuit] AS view_cuit,
		[Empresa_Direccion] AS view_domicilio,
		[Empresa_Rubro] AS view_id_rubro,
		[Rubro_Descripcion] AS view_descripcion

	FROM [GD2C2017].[gd_esquema].[Maestra]

GO

CREATE VIEW View_Factura AS

	SELECT DISTINCT
		
		[Nro_Factura] AS view_numero_factura,
		[Factura_Total] AS view_factura_monto_total,
		[Factura_Fecha] AS view_factura_fecha_alta,
		[Factura_Fecha_Vencimiento] AS view_factura_fecha_vencimiento,
		[Cliente-Dni] AS view_dni_cliente,
		[Empresa_Cuit] AS view_cuit_empresa

	FROM [GD2C2017].[gd_esquema].[Maestra]

GO

CREATE VIEW View_Item AS

	SELECT DISTINCT

		[Nro_Factura] AS view_numero_factura,
		[ItemFactura_Monto] AS view_monto,
		[ItemFactura_Cantidad] AS view_cantidad

	FROM [GD2C2017].[gd_esquema].[Maestra]

GO

CREATE VIEW View_Rendicion AS

	SELECT DISTINCT
		
		[Rendicion_Nro] AS view_numero_rendicion,
		[ItemRendicion_Importe] AS view_importe_comision,
		[Rendicion_Fecha] AS view_fecha_rendicion

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE Rendicion_Nro IS NOT NULL