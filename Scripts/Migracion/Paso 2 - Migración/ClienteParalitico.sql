INSERT INTO ClienteParalitico (Dni, Nombre, Apellido, Nacimiento, Mail, Domicilio, Codigo_Postal)

	SELECT DISTINCT

		p1.[Cliente-Dni] AS Dni,
		p1.[Cliente-Apellido] as Apellido,
		p1.[Cliente-Nombre] as Nombre,
		p1.Cliente_Mail as Mail,
		p1.[Cliente-Fecha_Nac] as Nacimiento,
		p1.Cliente_Direccion as Direccion,
		p1.Cliente_Codigo_Postal as Codigo_Postal

	FROM	gd_esquema.Maestra p1, gd_esquema.Maestra p2

	WHERE	p1.[Cliente-Dni] != p2.[Cliente-Dni] AND p1.Cliente_Mail = p2.Cliente_Mail;