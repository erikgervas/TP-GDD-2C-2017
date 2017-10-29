INSERT INTO Sucursal (cp_sucursal, nombre, domicilio, habilitadx)

	SELECT DISTINCT

		[Sucursal_Codigo_Postal] AS cp_sucursal,
		[Sucursal_Nombre] AS nombre,
		[Sucursal_Dirección] AS domicilio,
		habilitada = 1

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE Sucursal_Codigo_Postal IS NOT NULL

INSERT INTO Cliente(dni_cliente, nombre, apellido, nacimiento, mail, domicilio, codigo_postal, telefono, habilitadx)
	
	SELECT DISTINCT

		c1.view_dni_cliente AS dni_cliente,
		c1.view_apellido AS nombre,
		c1.view_nombre AS apellido,
		c1.view_nacimiento AS nacimiento,
		c1.view_mail AS mail,
		c1.view_domicilio AS domicilio,
		c1.view_codigo_postal AS codigo_postal,
		telefono = 0,
		habilitadx = 1

	FROM View_Cliente c1
	
	WHERE NOT EXISTS (SELECT 1 FROM View_Cliente_Conflictivo cc WHERE c1.view_dni_cliente = cc.view_dni_cliente)

SET IDENTITY_INSERT Rubro ON

INSERT INTO Rubro (id_rubro, descripcion)

	SELECT DISTINCT

		view_id_rubro AS id_rubro,
		view_descripcion AS descripcion 
		
	FROM View_Empresa_Rubro

SET IDENTITY_INSERT Rubro OFF

INSERT INTO Empresa (nombre, cuit, domicilio, dia_rendicion, habilitadx, id_rubro)

	SELECT DISTINCT 

		view_nombre AS nombre,
		view_cuit AS cuit,
		view_domicilio AS domicilio,
		dia_rendicion = 0,
		habilitadx = 1,
		view_id_rubro AS id_rubro

	FROM View_Empresa_Rubro;

SET IDENTITY_INSERT Rendicion ON;

INSERT INTO Rendicion (numero_rendicion, importe_comision, fecha_rendicion)

	SELECT DISTINCT
		
		[Rendicion_Nro] AS numero_rendicion,
		[ItemRendicion_Importe] AS importe_comision,
		[Rendicion_Fecha] AS fecha_rendicion

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE Rendicion_Nro IS NOT NULL

SET IDENTITY_INSERT Rendicion OFF;

INSERT INTO Factura (numero_factura, factura_monto_total, factura_fecha_alta, factura_fecha_vencimiento, dni_cliente, id_empresa, numero_rendicion)

	SELECT
		
		f.view_numero_factura AS numero_factura,
		f.view_factura_monto_total AS factura_monto_total,
		f.view_factura_fecha_alta AS factura_fecha_alta,
		f.view_factura_fecha_vencimiento AS factura_fecha_vencimiento,
		f.view_dni_cliente AS dni_cliente,
		e.id_empresa AS id_empresa,
		f.view_numero_rendicion AS numero_rendicion

	FROM View_Factura_Con_Rendicion f

	JOIN Empresa e ON f.view_cuit_empresa = e.cuit

	WHERE NOT EXISTS (SELECT 1 FROM View_Cliente_Conflictivo c WHERE f.view_dni_cliente = c.view_dni_cliente)

INSERT INTO Medio_De_Pago (descripcion)

	SELECT DISTINCT 

		view_medio_de_pago AS descripcion

	FROM View_Pago_Medio_De_Pago

SET IDENTITY_INSERT Pago ON;

INSERT INTO Pago (numero_pago, monto_total, fecha_pago, id_medio_de_pago, dni_cliente, cp_sucursal)

	SELECT DISTINCT
		
		p.view_numero_pago AS numero_pago,
		p.view_monto_total AS monto_total,
		p.view_fecha_pago AS fecha_pago,
		m.id_medio_de_pago AS id_medio_de_pago,
		p.view_dni_cliente AS view_dni_cliente,
		p.view_cp_sucursal AS view_cp_sucursal

	FROM

		View_Pago_Medio_De_Pago p

    JOIN Medio_De_Pago m ON m.descripcion = p.view_medio_de_pago

	WHERE NOT EXISTS (SELECT 1 FROM View_Cliente_Conflictivo c WHERE c.view_dni_cliente = p.view_dni_cliente)

SET IDENTITY_INSERT Pago OFF;

INSERT INTO Item (nombre, monto, cantidad, numero_factura)

	SELECT DISTINCT

		'Sin nombre' AS nombre,
		i.view_monto AS monto,
		i.view_cantidad AS cantidad,
		i.view_numero_factura AS numero_factura

	FROM View_Item i

	JOIN Factura f ON f.numero_factura = i.view_numero_factura;

INSERT INTO Item_Pago (id_item, numero_factura, numero_pago)
	
	SELECT DISTINCT

		i.id_item AS id_item,
		i.numero_factura AS numero_factura,
		p.numero_pago AS numero_pago

	FROM View_Item vi

	JOIN Item i ON i.numero_factura = vi.view_numero_factura
	JOIN Pago p ON p.numero_pago = vi.view_numero_pago

INSERT INTO Item_Rendicion(id_item, numero_rendicion)

	SELECT DISTINCT

		i.id_item AS id_item,
		r.numero_rendicion AS numero_rendicion

	FROM View_Item vi

	JOIN Item i ON i.numero_factura = vi.view_numero_factura
	JOIN Rendicion r ON r.numero_rendicion = vi.view_numero_rendicion - 1