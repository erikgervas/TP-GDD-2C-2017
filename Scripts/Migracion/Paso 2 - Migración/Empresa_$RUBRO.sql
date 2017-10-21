INSERT INTO Empresa (nombre, cuit, domicilio, dia_rendicion, habilitada, id_rubro)

	SELECT DISTINCT 

		[Empresa_Nombre] AS nombre,
		[Empresa_Cuit] AS cuit,
		[Empresa_Direccion] AS domicilio,
		dia_rendicion = 1,
		habilitada = 1,
		[Empresa_Rubro] AS id_rubro

	FROM [GD2C2017].[gd_esquema].[Maestra];