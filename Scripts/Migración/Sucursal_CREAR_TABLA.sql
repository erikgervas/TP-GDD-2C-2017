CREATE TABLE Sucursal (
	ID INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	Nombre NVARCHAR(255) NOT NULL,
	Domicilio NVARCHAR(255) NOT NULL,
	Codigo_Postal NVARCHAR(255) NOT NULL UNIQUE,
	Habilitada BIT
);

INSERT INTO Sucursal (Nombre, Domicilio, Codigo_Postal, Habilitada)

	SELECT DISTINCT

		[Sucursal_Nombre] AS Nombre,
		[Sucursal_Dirección] AS Domicilio,
		[Sucursal_Codigo_Postal] AS Codigo_Postal,
		Habilitada = 1

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE	Sucursal_Nombre IS NOT NULL AND
			Sucursal_Dirección IS NOT NULL AND
			Sucursal_Codigo_Postal IS NOT NULL