INSERT INTO Factura (numero_factura, factura_monto_total, factura_fecha_alta, factura_fecha_vencimiento, id_cliente, id_empresa)

	SELECT DISTINCT
		
		v.view_numero_factura AS numero_factura,
		v.view_factura_monto_total AS factura_monto_total,
		v.view_factura_fecha_alta AS factura_fecha_alta,
		v.view_factura_fecha_vencimiento AS factura_fecha_vencimiento,
		c.id_cliente AS id_cliente,
		e.id_empresa AS id_empresa

	FROM View_Factura v

	JOIN Cliente c ON v.view_dni_cliente = c.dni
	JOIN Empresa e ON v.view_cuit_empresa = e.cuit