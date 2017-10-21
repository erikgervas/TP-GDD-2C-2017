INSERT INTO Empresa (Nombre, Cuit, Domicilio, Habilitada, Id_Rubro)

	SELECT DISTINCT 

		[Empresa_Nombre] AS Nombre,
		[Empresa_Cuit] AS Cuit,
		[Empresa_Direccion] AS Domicilio,
		Habilitada = 1,
		[Empresa_Rubro] AS Id_Rubro

	FROM [GD2C2017].[gd_esquema].[Maestra];