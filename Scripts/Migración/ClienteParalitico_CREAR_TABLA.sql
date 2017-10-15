CREATE TABLE ClienteParalitico (
	ID INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	Dni NUMERIC(18,0) NOT NULL UNIQUE,
	Nombre NVARCHAR(255) NOT NULL,
	Apellido NVARCHAR(255) NOT NULL,
	Nacimiento DateTime NOT NULL,
	Mail NVARCHAR(255) NOT NULL /*UNIQUE*/, 
	Domicilio NVARCHAR(255) NOT NULL,
	Codigo_Postal NVARCHAR(255) NOT NULL,
	Telefono INT,
	Habilitado BIT,
	Repeticiones INT
);

INSERT INTO ClienteParalitico (Dni, Nombre, Apellido, Nacimiento, Mail, Domicilio, Codigo_Postal, Habilitado, Repeticiones)

	SELECT DISTINCT p1.[Cliente-Dni], p1.[Cliente-Apellido], p1.[Cliente-Nombre], p1.Cliente_Mail, p1.[Cliente-Fecha_Nac], p1.Cliente_Direccion, p1.Cliente_Codigo_Postal,
					p2.[Cliente-Dni], p2.[Cliente-Apellido], p2.[Cliente-Nombre], p2.Cliente_Mail, p2.[Cliente-Fecha_Nac], p2.Cliente_Direccion, p2.Cliente_Codigo_Postal

	FROM	gd_esquema.Maestra p1, gd_esquema.Maestra p2

	WHERE	p1.[Cliente-Dni] != p2.[Cliente-Dni] AND p1.Cliente_Mail = p2.Cliente_Mail;