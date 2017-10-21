INSERT INTO Cliente (Dni, Nombre, Apellido, Nacimiento, Mail, Domicilio, Codigo_Postal, Habilitado)

	SELECT DISTINCT

		[Cliente-Dni] AS Dni,
		[Cliente-Nombre] AS Nombre,
		[Cliente-Apellido] AS Apellido,
		[Cliente-Fecha_Nac] AS Nacimiento,
		[Cliente_Mail] AS Mail,
		[Cliente_Direccion] AS Domicilio,
		[Cliente_Codigo_Postal] AS Codigo_Postal,
		Habilitado = 1

	FROM [GD2C2017].[gd_esquema].[Maestra]
	
	WHERE NOT EXISTS (SELECT 1 FROM ClienteParalitico WHERE [Cliente-Dni] = ClienteParalitico.Dni);
