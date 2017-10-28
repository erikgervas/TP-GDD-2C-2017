INSERT INTO ClienteParalitico(dni, nombre, apellido, nacimiento, mail, domicilio, codigo_postal)

	SELECT DISTINCT

		c1.view_dni AS dni,
		c1.view_apellido AS nombre,
		c1.view_nombre AS apellido,
		c1.view_nacimiento AS nacimiento,
		c1.view_mail AS mail,
		c1.view_domicilio AS domicilio,
		c1.view_codigo_postal AS codigo_postal

	FROM View_Cliente c1, View_Cliente c2
	
	WHERE c1.view_dni != c2.view_dni AND c1.view_mail = c2.view_mail

INSERT INTO Cliente(dni, nombre, apellido, nacimiento, mail, domicilio, codigo_postal, telefono, estado)
	
	SELECT DISTINCT

		view_dni AS dni,
		view_apellido AS nombre,
		view_nombre AS apellido,
		view_nacimiento AS nacimiento,
		view_mail AS mail,
		view_domicilio AS domicilio,
		view_codigo_postal AS codigo_postal,
		telefono = 0,
		estado = 1

	FROM View_Cliente
	
	WHERE NOT EXISTS (SELECT dni FROM ClienteParalitico WHERE view_dni = dni)