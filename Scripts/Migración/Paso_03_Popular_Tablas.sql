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
		c1.view_apellido AS nombre,
		c1.view_nombre AS apellido,
		c1.view_nacimiento AS nacimiento,
		c1.view_mail AS mail,
		c1.view_domicilio AS domicilio,
		c1.view_codigo_postal AS codigo_postal,
		telefono = 0,
		habilitadx = 1

	FROM SQL_BOYS.View_Cliente c1
	
	WHERE NOT EXISTS (SELECT 1 FROM SQL_BOYS.View_Cliente_Conflictivo cc WHERE c1.view_dni_cliente = cc.view_dni_cliente)

SET IDENTITY_INSERT SQL_BOYS.Rubro ON

INSERT INTO SQL_BOYS.Rubro (id_rubro, descripcion)

	SELECT DISTINCT

		view_id_rubro AS id_rubro,
		view_descripcion AS descripcion 
		
	FROM SQL_BOYS.View_Empresa_Rubro

SET IDENTITY_INSERT SQL_BOYS.Rubro OFF

INSERT INTO SQL_BOYS.Empresa (nombre, cuit, domicilio, dia_rendicion, habilitadx, id_rubro)

	SELECT DISTINCT 

		view_nombre AS nombre,
		view_cuit AS cuit,
		view_domicilio AS domicilio,
		dia_rendicion = (SELECT TOP 1 DAY (r.fecha_rendicion) FROM SQL_BOYS.Rendicion r, SQL_BOYS.View_Factura f, SQL_BOYS.View_Empresa_Rubro e WHERE r.numero_rendicion = f.view_numero_rendicion AND f.view_cuit_empresa = e.view_cuit ORDER BY r.fecha_rendicion DESC),
		habilitadx = 1,
		view_id_rubro AS id_rubro

	FROM SQL_BOYS.View_Empresa_Rubro;

SET IDENTITY_INSERT SQL_BOYS.Rendicion ON;

INSERT INTO SQL_BOYS.Rendicion (numero_rendicion, importe_comision, fecha_rendicion)

	SELECT DISTINCT
		
		[Rendicion_Nro] AS numero_rendicion,
		[ItemRendicion_Importe] AS importe_comision,
		[Rendicion_Fecha] AS fecha_rendicion

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE Rendicion_Nro IS NOT NULL

SET IDENTITY_INSERT SQL_BOYS.Rendicion OFF;

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