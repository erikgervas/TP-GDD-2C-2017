SET IDENTITY_INSERT Rubro ON

INSERT INTO Rubro (id_rubro, descripcion)

	SELECT DISTINCT

	view_id_rubro AS id_rubro,
	view_descripcion AS descripcion 
		
	FROM View_Empresa_Rubro

SET IDENTITY_INSERT Rubro OFF

INSERT INTO Empresa (nombre, cuit, domicilio, estado, id_rubro)

	SELECT DISTINCT 

		view_nombre AS nombre,
		view_cuit AS cuit,
		view_domicilio AS domicilio,
		estado = 1,
		view_id_rubro AS id_rubro

	FROM View_Empresa_Rubro;