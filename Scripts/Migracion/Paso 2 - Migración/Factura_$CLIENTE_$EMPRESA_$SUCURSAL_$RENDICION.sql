INSERT INTO Factura (numero_factura, factura_monto_total, factura_fecha_alta, factura_fecha_vencimiento, id_cliente, id_empresa, numero_rendicion)

	SELECT DISTINCT
		
		[Nro_Factura] AS numero_factura,
		[Factura_Total] AS factura_monto_total,
		[Factura_Fecha] AS factura_fecha_alta,
		[Factura_Fecha_Vencimiento] AS factura_fecha_vencimiento,
		c.id_cliente AS id_cliente,
		e.id_empresa AS id_empresa,
		r.numero_rendicion AS numero_rendicion

	FROM

		[GD2C2017].[gd_esquema].[Maestra] m

	JOIN Cliente c ON m.[Cliente-Dni] = c.dni
	JOIN Empresa e ON m.Empresa_Cuit = e.cuit
	JOIN Rendicion r ON m.Rendicion_Nro = r.numero_rendicion;
