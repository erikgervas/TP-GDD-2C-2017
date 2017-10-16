CREATE TABLE Cliente (
	ID INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	Dni NUMERIC(18,0) NOT NULL UNIQUE,
	Nombre NVARCHAR(255) NOT NULL,
	Apellido NVARCHAR(255) NOT NULL,
	Nacimiento DATETIME NOT NULL,
	Mail NVARCHAR(255) NOT NULL UNIQUE, 
	Domicilio NVARCHAR(255) NOT NULL,
	Codigo_Postal NVARCHAR(255) NOT NULL,
	Telefono INT,
	Habilitado BIT
);

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
