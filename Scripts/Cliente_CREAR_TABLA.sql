CREATE TABLE Cliente (
	ID int primary key IDENTITY(1, 1) NOT NULL,
	Dni Numeric(18,0) NOT NULL UNIQUE,
	Apellido NVARCHAR(255) NOT NULL,
	Nombre NVARCHAR(255) NOT NULL,
	Nacimiento DateTime NOT NULL,
	Mail NVARCHAR(255) NOT NULL /*UNIQUE*/, 
	Domicilio NVARCHAR(255) NOT NULL,
	Codigo_Postal NVARCHAR(255) NOT NULL
)

INSERT INTO Cliente (Dni, Apellido, Nombre, Nacimiento, Mail, Domicilio, Codigo_Postal)
	
	SELECT DISTINCT

		[Cliente-Dni] AS Dni
		,[Cliente-Apellido] AS Apellido
		,[Cliente-Nombre] AS Nombre
		,[Cliente-Fecha_Nac] AS Nacimiento
		,[Cliente_Mail] AS Mail
		,[Cliente_Direccion] AS Domicilio
		,[Cliente_Codigo_Postal] AS Codigo_Postal

	FROM [GD2C2017].[gd_esquema].[Maestra]
