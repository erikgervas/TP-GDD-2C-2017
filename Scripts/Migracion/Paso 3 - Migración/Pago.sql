SET IDENTITY_INSERT Pago ON;

INSERT INTO Pago (Nro_Pago ,MontoTotal, Fecha_pago, Id_Medio_Pago, Id_Cliente, Id_Sucursal, Id_Rendicion, Id_Factura)

	SELECT DISTINCT
		
		[Pago_nro] AS Nro_Pago,
		[Total] AS MontoTotal,
		[Pago_Fecha] AS Fecha_pago,
		med.ID AS Id_Medio_Pago,
		c.ID AS Id_Cliente,
		s.ID AS Id_Sucursal,
		[Rendicion_Nro] AS Id_Rendicion,
		[Nro_Factura] AS Id_Factura

	FROM

		[GD2C2017].[gd_esquema].[Maestra] m

    JOIN MedioPago med ON m.[FormaPagoDescripcion] = med.Descripcion
	JOIN Cliente c ON m.[Cliente-Dni] = c.Dni
	JOIN Sucursal s ON m.Sucursal_Codigo_Postal = s.Codigo_Postal

	WHERE Pago_nro IS NOT NULL

SET IDENTITY_INSERT Pago OFF;