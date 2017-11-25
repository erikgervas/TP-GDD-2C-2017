/* Crear tablas */

SELECT DISTINCT

	[Cliente-Dni] AS view_dni_cliente,
	[Cliente-Apellido] AS view_apellido,
	[Cliente-Nombre] AS view_nombre,
	[Cliente-Fecha_Nac] AS view_nacimiento,
	Cliente_Mail AS view_mail,
	Cliente_Direccion AS view_domicilio,
	Cliente_Codigo_Postal AS view_codigo_postal

INTO SQL_BOYS.View_Cliente

FROM [GD2C2017].[gd_esquema].[Maestra]

GO

SELECT

	c1.view_dni_cliente AS view_dni_cliente,
	c1.view_apellido AS view_apellido,
	c1.view_nombre AS view_nombre,
	c1.view_nacimiento AS view_nacimiento,
	c1.view_mail AS view_mail,
	c1.view_domicilio AS view_domicilio,
	c1.view_codigo_postal AS view_codigo_postal

INTO SQL_BOYS.View_Cliente_Conflictivo

FROM SQL_BOYS.View_Cliente c1, SQL_BOYS.View_Cliente c2
	
WHERE c1.view_dni_cliente != c2.view_dni_cliente AND c1.view_mail = c2.view_mail

GO

SELECT DISTINCT
	
	Nro_Factura,
	[Cliente-Dni],
	ItemFactura_Cantidad,
	ItemFactura_Monto,
	ItemPago_nro,
	ItemRendicion_nro

INTO SQL_BOYS.View_Items

FROM gd_esquema.Maestra

WHERE [Cliente-Dni] NOT IN (SELECT view_dni_cliente FROM SQL_BOYS.View_Cliente_Conflictivo)

GO

/* Items */

SELECT DISTINCT

	Nro_Factura, ItemFactura_Cantidad, ItemFactura_Monto
	
FROM SQL_BOYS.View_Items

SELECT * FROM SQL_BOYS.Item

/* Items de pago */

SELECT DISTINCT Nro_Factura, ItemFactura_Cantidad, ItemFactura_Monto, ItemPago_nro

FROM SQL_BOYS.View_Items

WHERE ItemPago_nro IS NOT NULL

SELECT * FROM SQL_BOYS.Item_Pago

/* Items de rendición */

SELECT DISTINCT Nro_Factura, ItemFactura_Cantidad, ItemFactura_Monto, ItemRendicion_nro

FROM SQL_BOYS.View_Items

WHERE ItemRendicion_nro IS NOT NULL

SELECT * FROM SQL_BOYS.Item_Rendicion

/* Borrar tablas */

DROP TABLE

	SQL_BOYS.View_Cliente, 
	SQL_BOYS.View_Cliente_Conflictivo,
	SQL_BOYS.View_Items